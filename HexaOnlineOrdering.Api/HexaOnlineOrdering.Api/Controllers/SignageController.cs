using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Services.Interfaces;
using HexaOnlineOrdering.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HexaOnlineOrdering.Api.Controllers
{
    [Route("api/[controller]")]
    public class SignageController : ControllerBase
    {
   
        #region Field
        private readonly IAdvertiseService _adsService;
        private readonly IAWS3service _aws3service;
        #endregion

        public SignageController(IAdvertiseService adsService, IAWS3service aWS3Service)
        {
            _adsService = adsService ?? throw new ArgumentNullException(nameof(adsService));
            _aws3service = aWS3Service ?? throw new ArgumentException(nameof(aWS3Service));
        }

        [Authorize]
        [HttpGet("GetAll")]
        public async Task<List<AdvertiseModel>> GetAdsList(bool? isActive)
        {
            var advertisements = await _adsService.GetAdsAll(isActive);
            foreach (var ads in advertisements)
            {
                ads.Url = _aws3service.GenerateAwsFileUrl(ads.Url);
            }
            //
            return advertisements;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet("GetAds/{id}")]
        public async Task<AdvertiseModel> GetAds([FromRoute] int id)
        {
            var ads = await _adsService.GetAdsById(id);
            if (ads == null)
                throw new HexaDomainException($"Advertisement Id {id} cannot be found.");

            ads.Url = _aws3service.GenerateAwsFileUrl(ads.Url);
            return await _adsService.GetAdsById(id);
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpGet("GetDefaultOrderNumber")]
        public async Task<int> GetDefaultOrderNumber()
        {
            return await _adsService.GetDefaultOrderNumber();
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpPost("AddAds")]
        public async Task<AdvertiseModel> AddAds([FromForm] AdvertiseModel model)
        {
            if (model == null)
                throw new HexaDomainException("Create advertise failed.");
            else if (model.File == null)
                throw new HexaDomainException("File is required.");

            var uploadedFiles = await _aws3service.UploadFileToDOSpaceAsync(new List<IFormFile>() { model.File }, "Signage");
            if (uploadedFiles.Count < 1)
                throw new HexaDomainException("Unable to upload file.");


            int maxOrder = await _adsService.GetDefaultOrderNumber();
            model.FilePath = uploadedFiles[0].FileName;
            model.Url = uploadedFiles[0].FilePath;
            model.OrderNumber = maxOrder;
            await _adsService.AddAds(model);

            if (model.Id == 0)
                throw new HexaDomainException("Create advertise failed.");
            return model;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpPut("EditAds")]
        public async Task<AdvertiseModel> EditAds([FromForm] AdvertiseModel model)
        {
            var ads = await _adsService.GetAdsById(model.Id);
            if (ads == null)
                throw new HexaDomainException($"Advertisement Id {model.Id} cannot be found.");

            // If file is empty then not to update file name and url
            // If file is not empty then to the upload process
            if (model.File == null)
            {
                model.FilePath = ads.FilePath;
                model.Url = ads.Url;
            }
            else
            {
                // Delete the file from server.
                await _aws3service.RemoveFileFromDOSpaceAsync(ads.Url);

                var uploadedFiles = await _aws3service.UploadFileToDOSpaceAsync(new List<IFormFile>() { model.File }, "Signage");
                if (uploadedFiles.Count < 1)
                    throw new HexaDomainException("Unable to upload file.");

                model.FilePath = uploadedFiles[0].FileName;
                model.Url = uploadedFiles[0].FilePath;
            }

            int result = await _adsService.EditAds(model);

            if (result == 0)
                throw new HexaDomainException("Update advertise failed.");
            return model;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpDelete("DeleteAds/{id}")]
        public async Task<int> DeleteAds([FromRoute] int id)
        {
            var ads = await _adsService.GetAdsById(id);
            if (ads == null)
                throw new HexaDomainException($"Advertisement Id {id} cannot be found.");

            int result = await _adsService.DeleteAdsById(id);
            if (result == 0)
                throw new HexaDomainException("Delete advertise failed.");

            // Delete the file from server.
            await _aws3service.RemoveFileFromDOSpaceAsync(ads.Url);

            return id;
        }

        [Authorize(Roles = "Admin,Staff")]
        [HttpPut("Reorder")]
        public async Task<bool> ReorderAdvertisement([FromBody] AdvertisementOrderModel sortModel)
        {
            // Get with decending order.
            var adsList = await _adsService.GetAdsAll();
            for (int i = 0; i < adsList.Count; i++)
            {
                if (adsList[i].Id == sortModel.AvertisementId)
                {
                    if (sortModel.MoveUp)
                    {
                        adsList[i - 1].OrderNumber = adsList[i].OrderNumber;
                        adsList[i].OrderNumber = adsList[i].OrderNumber - 1;
                    }
                    else
                    {
                        adsList[i + 1].OrderNumber = adsList[i].OrderNumber;
                        adsList[i].OrderNumber = adsList[i].OrderNumber + 1;
                    }
                }
            }

            await _adsService.EditAdsList(adsList);
            return true;
        }
    }

}
