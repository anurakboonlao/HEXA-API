using System;
using DinkToPdf;
using DinkToPdf.Contracts;
using HexaOnlineOrdering.Api.Exceptions;
using HexaOnlineOrdering.Api.Options;
using Microsoft.Extensions.Options;

namespace HexaOnlineOrdering.Api.Utils
{
    public class PdfConvertor
    {
        private readonly IConverter _converter;
        private readonly IOptions<PdfSetting> _pdfSetting;
        public PdfConvertor(IConverter convertor, IOptions<PdfSetting> pdfSetting)
        {
            _converter = convertor;
            _pdfSetting = pdfSetting;
        }

        public byte[] ConvertHtmlToPDF(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Landscape,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 0, Bottom = 0, Left = 0, Right = 0 },
                //TODO: DPI for mac is 380, Test it in windows is 300
                DPI = _pdfSetting.Value.Dpi,
            };

            var objectSettings = new ObjectSettings
            {
                HtmlContent = htmlContent,
                WebSettings = {
                    DefaultEncoding = "utf-8",
                    EnableIntelligentShrinking  = true,
                },
            };

            var htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };

            byte[] pdf = new byte[] { };
            try
            {
                pdf = _converter.Convert(htmlToPdfDocument);
            }
            catch (Exception e)
            {
                throw new HexaDomainException($"Cannot convert HTML to PDF {e.Message}");
            }

            return pdf;
        }

        public string GenerateFileName(string name)
        {
            string result = name + "_" + DateTime.UtcNow.Ticks.ToString();
            return result;
        }
    }
}