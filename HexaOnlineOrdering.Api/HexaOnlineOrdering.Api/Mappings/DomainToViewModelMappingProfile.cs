using System;
using AutoMapper;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Models.CasePresentationHistory;
using HexaOnlineOrdering.Models.Marketing;
using HexaOnlineOrdering.Repositories.DataModels;
using HexaOnlineOrdering.Repositories.MarketingDataModels;

namespace HexaOnlineOrdering.Api.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<TblUser, UserModel>().ForMember(u => u.AdminProductTypePermission, output => output.MapFrom(src => src.UserRole != null && src.UserRole.ProductType != null ? src.UserRole.ProductType : null));
            CreateMap<TblProduct, ProductOnlineOrderModel>();
            CreateMap<TblMethod, MethodModel>();
            CreateMap<TblProductType, ProductTypeModel>();
            CreateMap<TblCaseAttachedFile, CaseAttachedFileModel>();
            CreateMap<TblCase, CaseModel>();
            CreateMap<TblCaseProduct, CaseProductModel>();
            CreateMap<TblCaseProduct, CaseProductModel>()
                    .ForMember(dst => dst.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<TblAds, AdvertiseModel>();

            CreateMap<UserModel, TblUser>();
            CreateMap<ProductOnlineOrderModel, TblProduct>();
            CreateMap<MethodModel, TblMethod>();
            CreateMap<ProductTypeModel, TblProductType>();
            CreateMap<CaseAttachedFileModel, TblCaseAttachedFile>();
            CreateMap<CaseModel, TblCase>();
            CreateMap<CaseProductModel, TblCaseProduct>();
            CreateMap<CaseProductModel, TblCaseProduct>()
                    .ForMember(dst => dst.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<AdvertiseModel, TblAds>();
            CreateMap<Member, MarketingMemberModel>();
            CreateMap<UserModel, TblUser>();

            CreateMap<TblFavorite, FavoriteModel>();
            CreateMap<FavoriteModel, TblFavorite>();
            CreateMap<TblOrder, OrderModel>();

            CreateMap<Zone, MarketingZoneModel>();
            CreateMap<ZoneMember, MarketingZoneMemberModel>();

            CreateMap<RejectNoteModel, TblRejectNote>();
            CreateMap<TblRejectNote, RejectNoteModel>();

            CreateMap<TblCasePresentationHistory, CasePresentationHistoryModel>(); 
            CreateMap<TblCaseAttachedFile, DisplayAttachFile>();
        }
    }
}
