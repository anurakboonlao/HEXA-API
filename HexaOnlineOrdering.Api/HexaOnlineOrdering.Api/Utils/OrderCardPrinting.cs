using System;
using System.Collections.Generic;
using System.IO;
using HexaOnlineOrdering.Models;

namespace HexaOnlineOrdering.Api.Utils
{
	public class OrderCardPrinting
	{
		private MessageUtil _messageUtil;
		public OrderCardPrinting()
		{
			_messageUtil = new MessageUtil();
		}
		public const string HTML_FONTFACE = "{HtmlFontFace}";
		public const string HTML_ICON = "{HtmlIcon}";
		public const string HTML_BODY = "{HtmlBody}";
		public const string MAIN_COLOR = "#0F75BD";

		public const string HTML_TABLE_STYLE = "table-layout: fixed; border-collapse: collapse; width: 130mm; text-align: start; word-break: normal; font-family: prompt;font-size: 14px; font-weight:400; line-height: 21px;";

		public const string ORDER_REF = "{OrderRef}";
		public const string CLINIC_NAME = "{ClinicName}";
		public const string DOCTOR_NAME = "{DoctorName}";
		public const string PATIENT_NAME = "{PatientName}";
		public const string RQ_DATE = "{RequestDeliveryDate}";
		public const string TABLE_HTML = "{TableProduct}";

		public const string PAGE_NUMBER = "{PageNumber}";

		public const string HTML_MAIN = @"<!DOCTYPE HTML>
		<html>
		<head>
		<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'></meta>
		<title>Hexa Online Order Printing</title>
		<style type='text/css'>
			body {
				/* A5 paper size */
			    height: 250mm;
				word-break: break-all;
				/* Default body from PDF Editor */
				font-family: prompt;
    			font-size: 12pt;
				font-weight:400;
			}
			.page {
				page-break-after:always;				
				padding-top: 5mm;
				position:relative;

			  display: -webkit-box;
			  display: -webkit-flex;
			  display: flex;
			}
			.grid{
				
			}
			.card {
				/* A5 paper size height: 210mm; width: 148mm;*/
				/*height: 250mm;*/
				width: 180mm;
				margin-left: 5mm;
				margin-right: 5mm;
			}
			.card-header{
				display: -webkit-box;
				display: -webkit-flex;
				display: flex;
				color: #0F75BD;
				margin-bottom: 15px
			}
			.card-header > div{
				-webkit-box-flex: 1;
				-webkit-flex: 1;
				flex: 1;		
			}
			.address-title{
				font-family: prompt-mid;
				font-size: 9px;
				font-weight:500;
			}
			.address-description{
				font-family: prompt;
				font-size: 8px;
				font-weight:400;
			}
			.card-body{
				border: 2px solid #0F75BD;
				min-height: 238mm;
			}
			.form-header{
				background-color: #0f75BD;
				color: #ffffff;
				text-align: center;
				padding-top: 7px;
				padding-bottom: 7px;
			}
			.form-body{
				padding:10px;
				color: #0F75BD;
			}
			.form-input{
				margin-bottom: 6px;
				text-align: start;
			}
			.table-border{
				border-bottom: 1px solid #0F75BD;
				padding: 0px;
			}
			.ref-line{
				font-size: 17px; 
				font-family: prompt-mid; 
				font-weight:500; 
				margin-bottom: 6px;

				display: -webkit-box;
				display: -webkit-flex;
				display: flex;
			}
			.ref-line > div {
			  -webkit-box-flex: 1;
			  -webkit-flex: 1;
			  flex: 1;
			  text-align: center;
			  margin-right: 10%;
			}
			.ref-line > div:last-child {
				margin-right: 0;
				text-align: end;
			}
			.col-right{

			}
		</style>
		<link href='{HtmlFontFace}' rel='stylesheet' type='text/css' media='screen'></link>
		</head>
		<body>
			{HtmlBody}
		</body>
		</html>";

		public string GetDocumentHtml(List<DisplayOrder> orderData)
		{

			string html = GetLetterHtmlBase(orderData);

			return html;
		}


		private string GetLetterHtmlBase(List<DisplayOrder> orderData)
		{
			string html = HTML_MAIN;

			string cssPath = Path.Combine(Environment.CurrentDirectory, "Fonts", "FontFace.css");
			html = html.Replace(HTML_FONTFACE, cssPath);

			//string templateHtml = letter.Language == LanguageConstant.TH ? letter.LetterTemplate.Template.TH : letter.LetterTemplate.Template.EN;
			//templateHtml = ReplaceLetterData(templateHtml, letter);

			html = html.Replace(HTML_BODY, LayoutCard(orderData));

			return html;
		}

		private string LayoutCard(List<DisplayOrder> orderData)
		{
			string layout = "";

			List<string> cards = GetCardPage(orderData);

			for (int i = 0; i < cards.Count; i = i + 2)
			{
				layout += "<div class='page'>";

				string row = @$"<div class='col-left'>{cards[i]}</div>";
				//(i + 1)+1: i+1 is next index and then +1 for compair with order count
				if (i + 2 <= cards.Count)
				{
					row += @$"<div class='col-right'>{cards[i + 1]}</div>";
				}
				else
				{
					row += @$"<div class='col-right'>
							<div class='card'></div>
						</div>";
				}

				row += "</div>";
				layout += row;

				layout += "</div>";
			}
			return layout;
		}

		private List<string> GetCardPage(List<DisplayOrder> orderData)
        {
			List<string> reault = new List<string>();
            foreach (DisplayOrder order in orderData)
            {
				Dictionary<int, List<CaseItemModel>> brakeItems = BrakeItems(order);
                foreach (KeyValuePair<int, List<CaseItemModel>> casePage in brakeItems)
                {
					string card = OrderCardTemplate(order, casePage.Value);
					card = card.Replace(PAGE_NUMBER, GetPageNumber(casePage.Key, brakeItems.Count));
					reault.Add(card);
				}

			}
			return reault;
		}

		int MAX_LINE_CHAR = 28;

		private string GetPageNumber(int currentPage, int totalPage)
        {
			return string.Format("หน้า {0}/{1}", currentPage, totalPage);
        }

		private Dictionary<int, List<CaseItemModel>> BrakeItems(DisplayOrder order)
		{
			Dictionary<int, List<CaseItemModel>> brakeResult = new Dictionary<int, List<CaseItemModel>>();
			int maxHeightPerPage = 500;
			//cellWidth = 127 px

			if (order.DisplayCase.CaseOrderLists == null)
				return brakeResult;

			int currentHeight = 0;
			List<CaseItemModel> items = new List<CaseItemModel>(); 
			foreach (CaseItemModel item in order.DisplayCase.CaseOrderLists)
			{
				//product name line
				int nameLine = CalculateLine(item.SelectProduct.Name,false);
				int shadeLine = GetShadeLine(item);
				int addOnLine = GetAddOnLine(item.SelectAddOn);

				int maxLine = Math.Max(nameLine, shadeLine);
				maxLine = Math.Max(maxLine, addOnLine);

				int rowHight = GetPxFromLineHeight(maxLine);
				if(currentHeight + rowHight < maxHeightPerPage)
                {
					currentHeight += rowHight;
					items.Add(item);
				}
                else
                {
					brakeResult.Add(brakeResult.Count + 1, items);
					currentHeight = rowHight;
					items = new List<CaseItemModel>();
					items.Add(item);
					continue;
				}
			}
			if(items.Count > 0)
            {
				//end of items
				brakeResult.Add(brakeResult.Count + 1, items);
			}

			return brakeResult;
		}

		private int GetPxFromLineHeight(int numberOfLine)
        {
			int lineHeigh = 22;
			return numberOfLine * lineHeigh;
		}

		private int GetAddOnLine(List<SelectedAddOnModel> addOns)
		{
			int line = 0;
			if (addOns != null && addOns.Count > 0)
			{
				//html += "<ul>";
				foreach (SelectedAddOnModel addon in addOns)
				{
					line += CalculateLine(displayAddon(addon), true);
				}
				return line;
			}
			return 1;
		}

		private int GetShadeLine(CaseItemModel item)
		{
			if (!string.IsNullOrEmpty(item.SelectShade) && !string.IsNullOrEmpty(item.SelectShadeSystem) && (item.ProductTypeId == 1 || item.ProductTypeId == 2))
			{
				string shade = string.Format("Shade: ", item.SelectShade);
				string shadeSyatem = $@"Shade System: { (item.SelectShadeSystem != "" ? item.SelectShadeSystem : " - ")}";
				string substitutionTooth = $@"Subsitute Tooth: { (item.SubstitutionTooth != "" ? item.SubstitutionTooth : " - ")}";
		
			int line = CalculateLine(shade, true);
				line += CalculateLine(shadeSyatem, true);
				if(item.ProductTypeId == 2)
				line += CalculateLine(substitutionTooth, true);
			return line;
			}
			return 1;
		}

		private int CalculateLine(string text,bool isList)
        {
			if (isList)
				return CalculateListLine(text);
			else
				return CalculateSingleLine(text);

		}

		private int CalculateSingleLine(string text)
		{
			int line = text.Length / MAX_LINE_CHAR;
			if (text.Length % MAX_LINE_CHAR > 0)
				line++;

			return line;
		}
		private int CalculateListLine(string text)
		{
			return CalculateSingleLine(text);

		}

		private string OrderCardTemplate(DisplayOrder order, List<CaseItemModel> filterItems)
		{
			string template = $@"
				<div class='card'>
					{CardHeader()}
					{CardBody()}
				</div>
			";

			template = ReplaceKeyField(template, order);

			template = template.Replace(TABLE_HTML, GetProductTable(filterItems));

			return template;
		}

		private string CardHeader()
		{
			string html = $@"
				<div class='card-header'>
					<div >
						  <img src='{HTML_ICON}' style='width: 30mm;'/>
					</div>
					<div style='text-align: start;'>
						<div class='address-title'>สำนักงานใหญ่ จ.เชียงใหม่</div>
						<div class='address-description'>โทรศัพท์ 053-350801-2</div>
						<div class='address-description'>โทรส่าร 053-351652</div>

						<div class='address-title'>สาขา จ.นครสวรรค์่</div>
						<div class='address-description'>โทรศัพท์ 056-883094</div>
					</div>
					<div style='text-align: start;'>
						<div class='address-title'>สาขา กรุงเทพมหานคร</div>
						<div class='address-description'>โทรศัพท์ 02-1307380-2</div>
						<div class='address-description'>โทรส่าร 02-1307383</div>

						<div class='address-title'>สาขา จ.อุบลราชธานี</div>
						<div class='address-description'>โทรศัพท์ 045-844633</div>
					</div>
					<div style='text-align: start;'>
						<div class='address-title'>สาขา จ.เชียงราย</div>
						<div class='address-description'>โทรศัพท์ 053-713502</div>
						<div class='address-description'>โทรส่าร 053-719000</div>

						<div class='address-title'>สาขา จ.อุดรธานี</div>
						<div class='address-description'>โทรศัพท์ 042-124066</div>
					</div>
					<div style='text-align: start;'>
						<div class='address-title'>สาขา จ.พิษณุโลก</div>
						<div class='address-description'>โทรศัพท์ 055-906505</div>
						<div class='address-description'>โทรส่าร 055-906506</div>

						<div class='address-title'>สาขา จ.ชลบุรี</div>
						<div class='address-description'>โทรศัพท์ 038-397003</div>
					</div>
				</div>
			";
			string cssPath = Path.Combine(Environment.CurrentDirectory, "image", "logo-haxa-ceram.png");
			html = html.Replace(HTML_ICON, cssPath);
			return html;
		}

		private string CardBody()
		{
			string html = $@"
				<div class='card-body'>
				{FormHeader()}
				{FormBody()}
				</div>
			";
			return html;
		}
		private string FormHeader()
		{
			string html = $@"
				<div class='form-header'>
					<div style='font-size: 20px; font-family: prompt;'>แบบฟอร์ม Online Order</div>
					<div style='font-size: 15px; font-family: prompt;'>กรุณาแนบมาพร้อมกับงานทุกครั้ง</div>
				</div>
			";
			return html;
		}
		private string FormBody()
		{
			string html = $@"
				<div class='form-body'>
					<div class='ref-line'>
						<div style='opacity: 0;'>
							{PAGE_NUMBER}
						</div>
						<div>
							{ORDER_REF} 
						</div>
						<div>
							{PAGE_NUMBER}
						</div>
					</div>
					{InputForm("คลินิก/โรงพยาบาล", CLINIC_NAME)}
					{InputForm("ทันตแพทย์", DOCTOR_NAME)}
					{InputForm("คนไข้", PATIENT_NAME)}
					{InputForm("วันที่ต้องการได้รับชิ้นงาน", RQ_DATE)}
					{ProductTable()}
				</div>
			";
			return html;
		}
		private string InputForm(string title, string tagName)
		{
			string html = $@"
				<div class='form-input'>
					<div style='font-size: 14px; font-family: prompt-mid; font-weight:500; margin-bottom: 3px;'>{title}</div>
					<div style='font-size: 13px; font-family: prompt; font-weight:400; border: solid; padding: 2px;'>{tagName}</div>
				</div>
			";
			return html;
		}
		private string ProductTable()
		{
			string html = $@"
				<div class='form-input'>
					<div style='font-size: 14px; font-family: prompt-mid; margin-bottom: 3px;'>Order List</div>
					{TABLE_HTML}
				</div>
			";
			return html;
		}

		private string CardFooter()
		{
			string html = $@"
			";
			return html;
		}

		private string GetProductTable(List<CaseItemModel> caseOrderLists)
		{
			if (caseOrderLists == null) { return ""; }

			//Table Header
			string tableHtml = @$"<table style='{HTML_TABLE_STYLE}'>
	                            <thead>
		                            <th class='table-border' style='width: 17mm;text-align:start;'>Arch/No.</th>
		                            <th class='table-border' style='width: 52mm;text-align:start;'>Product</th>
									<th class='table-border' style='width: 52mm;text-align:start;'>Shade</th>
									<th class='table-border' style='width: 52mm;text-align:start;'>Add-on</th>
	                            </thead>
                                ";
			tableHtml += "<tbody style='vertical-align: top; font-family: prompt;font-size: 14px; font-weight:400;text-align: start;color: #0F75BD'>";

			//Table Body
			foreach (CaseItemModel item in caseOrderLists)
			{
				string displayProduct = item.SelectProduct.Name;
				if (item.SelectProduct.ProductTypeId == 5)
					displayProduct = string.Format("ICHARM {0}", displayProduct);

				tableHtml += "<tr>";
				tableHtml += $"<td class='table-border' style='word-wrap: break-word;'>{GetNo(item)}</td>";
				tableHtml += $"<td class='table-border' style='word-wrap: break-word;'>{displayProduct}</td>";
				tableHtml += $"<td class='table-border' style='word-wrap: break-word;'>{GetShades(item.SelectShade, item.SelectShadeSystem,item.SubstitutionTooth, item.ProductTypeId)}</td>";
				tableHtml += $"<td class='table-border' style='word-wrap: break-word;'>{GetAddOns(item.SelectAddOn)}</td>";
				tableHtml += "</tr>";
			}

			tableHtml += "</tbody>";
			tableHtml += "</table>";
			return tableHtml;
		}

		private string GetNo(CaseItemModel item)
		{
			int teethNumber = 0;
			if (int.TryParse(item.No, out teethNumber))
				return item.No;
			if (string.IsNullOrEmpty(item.No))
				return "";
			if (item.No.ToLower() == "maxilla")
				return "upper";
			if (item.No.ToLower() == "mandible")
				return "lower";
			return "";
		}

		private string GetMaterial(MaterialModel material)
		{
			if (material != null && material.Name != "")
			{
				return material.Name;
			}
			return "-";
		}

		private string GetDesign(DesignModel design)
		{
			if (design != null && design.Name != "")
			{
				return design.Name;
			}
			return "-";
		}

		private string GetShades(string shade, string shadeSystem, string subsituteTooth, int productTypeId)
		{
			string html = "";
			if(!string.IsNullOrEmpty(shadeSystem) && !string.IsNullOrEmpty(shade) && ( productTypeId == 1 || productTypeId == 2))
			{
				html += $@"<li> Shade: {(shade != "" ? shade : " - ")}</li>";
				html += $@"<li> Shade System: {(shadeSystem != "" ? shadeSystem : " - ")}</li>";
				if(productTypeId == 2 && !string.IsNullOrEmpty(subsituteTooth))
					html += $@"<li> Subsitute Tooth: {(subsituteTooth != "" ? subsituteTooth : " - ")}</li>";
			}
			return html;
		}

		private string GetAddOns(List<SelectedAddOnModel> addOns)
		{
			string html = "";
			if (addOns != null && addOns.Count > 0)
			{
				//html += "<ul>";
                foreach (SelectedAddOnModel addon in addOns)
                {
					html += $"<li><span> {displayAddon(addon)}</span></li>";
                }
				//html += "</ul>";
			}
			return html;
		}

		private string displayAddon(SelectedAddOnModel addon)
        {
			string display = addon.DisplayName;
            if (addon.RequiredInput)
            {
				if(addon.InputType.HasValue && addon.InputType.Value == HexaOnlineOrdering.Models.AddOnInputTypeEnum.TeethNumber)
                {
					display += " #";
				}
                else
                {
					display += " ";
				}
				display += addon.Input;
			}
			return display;
		}

		private string ReplaceKeyField(string html, DisplayOrder order)
        {
			html = html.Replace(ORDER_REF, order.OrderRef);
			html = html.Replace(CLINIC_NAME, order.ClinicName);
			html = html.Replace(DOCTOR_NAME, order.DentistName);
			html = html.Replace(PATIENT_NAME, order.PatientName);
			html = html.Replace(RQ_DATE, order.RequestDeliveryDate.HasValue? _messageUtil.ToThaiTime(order.RequestDeliveryDate.Value).ToString("yyyy-MM-dd"):"-");

			return html;
		}
	}
}
