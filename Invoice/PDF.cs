using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text.html;

namespace Invoice
{
    class PDF
    {
        


        public void Make()
        {
            try
            {

                FileStream fs = new FileStream("Chapter1_Example1.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

                Document document = new Document();

                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                document.Open();

                var titleFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
                var titleFontBlue = FontFactory.GetFont("Arial", 14, Font.NORMAL, BaseColor.BLUE);
                var boldTableFont = FontFactory.GetFont("Arial", 10, Font.BOLD);
                var bodyFont = FontFactory.GetFont("Arial", 10, Font.NORMAL);
                var EmailFont = FontFactory.GetFont("Arial", 8, Font.NORMAL, BaseColor.BLUE);
                BaseColor TabelHeaderBackGroundColor = WebColors.GetRGBColor("#EEEEEE");



                // Header 
                {
                    PdfPTable headerT = new PdfPTable(3);
                    PdfPCell cell = new PdfPCell(new Phrase(""));

                    cell.Colspan = 3;

                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    cell.Border = Rectangle.NO_BORDER;
                    headerT.AddCell(cell);

                    float[] widths = new float[] { 2f, 4f, 6f };

                    headerT.SetWidths(widths);
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    headerT.WidthPercentage = 100;
                    headerT.SetWidths(new float[] { 300f, 100f, 150f });  // then set the column's __relative__ widths
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    string[] headerInfo = new string[] { "Activity Date: 7 / 9/ 2018", "", "Claim Number: 12345",
                                                    "Invoice Date: June 2, 2018"," ", "Provider File# JOD"};

                    foreach (string str in headerInfo)
                    {
                        PdfPCell cell1 = new PdfPCell(new Phrase(str, boldTableFont));
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        cell1.Border = Rectangle.NO_BORDER;
                        headerT.AddCell(cell1);
                    }

                    headerT.PaddingTop = 10F;

                    document.Add(headerT);

                }

                // Space 
                {
                    Paragraph title = new Paragraph();
                    title.Add("\n");
                    document.Add(title);
                }

                // Header 2 
                {
                    PdfPTable headerT = new PdfPTable(2);
                    PdfPCell cell = new PdfPCell(new Phrase(""));

                    cell.Colspan = 2;

                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    cell.Border = Rectangle.NO_BORDER;
                    headerT.AddCell(cell);

                    float[] widths = new float[] { 6f, 6f };

                    headerT.SetWidths(widths);
                    headerT.WidthPercentage = 100;


                    headerT.SetWidths(new float[] { 300f, 300f });  // then set the column's __relative__ widths

                    string[] headerInfo = new string[] {    "Insuer: Blue Cross Services\njoe.dirt@bluecross.com\n\nCalim Representative: Joe White",
                                                            "Employee: Joe Walsh\nDOI: 07/21/2017",
                                                            "Provider: CompanyName    Rec#112\n\n    Minneapolis, MN, 55429\n    Phone 999-772-2345",
                                                            "Cost to date:\n    Current Firm\n    Total Bill: " };


                    foreach (string str in headerInfo)
                    {

                        PdfPCell cell1 = new PdfPCell(new Phrase(str, boldTableFont));
                        cell1.BackgroundColor = TabelHeaderBackGroundColor;
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        headerT.AddCell(cell1);
                    }

                    headerT.PaddingTop = 10F;

                    document.Add(headerT);
                }

                // Title 
                {
                    Paragraph title = new Paragraph();
                    title.Alignment = Element.ALIGN_CENTER;
                    title.Font = FontFactory.GetFont("Arial", 18, Font.BOLD);
                    title.Add("\nVocational Rehabilitation Services Billing Summary");
                    document.Add(title);

                }

                // Information 
                {
                    Paragraph title = new Paragraph();
                    title.Font = bodyFont;
                    title.Add("\nInsured Amazon.com\n");
                    title.Add("Date of Service Began 03/01/2018\n");
                    document.Add(title);
                }

                // Space 
                {
                    Paragraph title = new Paragraph();
                    title.Add("\n");
                    document.Add(title);
                }


                // Tabel 
                {

                    //Create body table
                    PdfPTable itemTable = new PdfPTable(4);

                    itemTable.HorizontalAlignment = 0;
                    itemTable.WidthPercentage = 100;
                    itemTable.SetWidths(new float[] { 60, 10, 10, 15 });  // then set the column's __relative__ widths
                    itemTable.SpacingAfter = 40;
                    itemTable.DefaultCell.Border = Rectangle.BOX;
                    PdfPCell cell2 = new PdfPCell(new Phrase("PROFESSIONAL SERVICES RENDERED", boldTableFont));
                    cell2.BackgroundColor = TabelHeaderBackGroundColor;
                    cell2.HorizontalAlignment = 1;
                    itemTable.AddCell(cell2);
                    PdfPCell cell3 = new PdfPCell(new Phrase("CODE", boldTableFont));
                    cell3.BackgroundColor = TabelHeaderBackGroundColor;
                    cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell3);
                    PdfPCell cell4 = new PdfPCell(new Phrase("TIME", boldTableFont));
                    cell4.BackgroundColor = TabelHeaderBackGroundColor;
                    cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell4);
                    PdfPCell cell5 = new PdfPCell(new Phrase("TOTAL", boldTableFont));
                    cell5.BackgroundColor = TabelHeaderBackGroundColor;
                    cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell5);
                    //foreach (DataRow row in dt.Rows)
                    {
                       

                        var _phrase = new Phrase();
                        _phrase.Add(new Chunk("New Signup Subscription Plan\n", bodyFont));
                        PdfPCell descCell = new PdfPCell(_phrase);
                        descCell.HorizontalAlignment = 0;
                        descCell.PaddingLeft = 10f;
                        descCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                        itemTable.AddCell(descCell);

                        PdfPCell qtyCell = new PdfPCell(new Phrase("1", bodyFont));
                        qtyCell.HorizontalAlignment = 1;
                        qtyCell.PaddingLeft = 10f;
                        qtyCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                        itemTable.AddCell(qtyCell);

                        PdfPCell amountCell = new PdfPCell(new Phrase("$100", bodyFont));
                        amountCell.HorizontalAlignment = 1;
                        amountCell.PaddingLeft = 10f;
                        amountCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                        itemTable.AddCell(amountCell);

                        PdfPCell totalamtCell = new PdfPCell(new Phrase("$100", bodyFont));
                        totalamtCell.HorizontalAlignment = 1;
                        totalamtCell.Border = Rectangle.LEFT_BORDER | Rectangle.RIGHT_BORDER;
                        itemTable.AddCell(totalamtCell);

                    }
                    // Table footer
                    {
                        PdfPCell totalAmtStrCell = new PdfPCell(new Phrase("Total - Profesional Services Rendered", boldTableFont));
                        totalAmtStrCell.Border = Rectangle.TOP_BORDER | Rectangle.RIGHT_BORDER;   //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
                        totalAmtStrCell.HorizontalAlignment = 1;
                        totalAmtStrCell.Colspan = 2;
                        itemTable.AddCell(totalAmtStrCell);
                        PdfPCell totalAmtCell = new PdfPCell(new Phrase("10", boldTableFont));
                        totalAmtCell.HorizontalAlignment = 1;
                        itemTable.AddCell(totalAmtCell);
                        PdfPCell totalAmtCell3 = new PdfPCell(new Phrase("$100", boldTableFont));
                        totalAmtCell3.HorizontalAlignment = 1;
                        itemTable.AddCell(totalAmtCell3);
                    }

                    // Table footer
                    {
                        PdfPCell totalAmtStrCell = new PdfPCell(new Phrase("Total Expenses Rendered", boldTableFont));
                        totalAmtStrCell.Border = Rectangle.NO_BORDER;   //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
                        totalAmtStrCell.HorizontalAlignment = 1;
                        totalAmtStrCell.Colspan = 2;
                        itemTable.AddCell(totalAmtStrCell);
                        PdfPCell totalAmtCell = new PdfPCell(new Phrase(" ", boldTableFont));
                        totalAmtCell.HorizontalAlignment = 1;
                        totalAmtCell.Border = Rectangle.NO_BORDER;
                        itemTable.AddCell(totalAmtCell);
                        PdfPCell totalAmtCell3 = new PdfPCell(new Phrase("$100", boldTableFont));
                        totalAmtCell3.HorizontalAlignment = 1;
                        itemTable.AddCell(totalAmtCell3);
                    }

                    // Table footer
                    {
                        PdfPCell totalAmtStrCell = new PdfPCell(new Phrase("Total Mileage - 76 @ .50", boldTableFont));
                        totalAmtStrCell.Border = Rectangle.NO_BORDER;   //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
                        totalAmtStrCell.HorizontalAlignment = 1;
                        totalAmtStrCell.Colspan = 2;
                        itemTable.AddCell(totalAmtStrCell);
                        PdfPCell totalAmtCell = new PdfPCell(new Phrase(" ", boldTableFont));
                        totalAmtCell.HorizontalAlignment = 1;
                        totalAmtCell.Border = Rectangle.NO_BORDER;
                        itemTable.AddCell(totalAmtCell);
                        PdfPCell totalAmtCell3 = new PdfPCell(new Phrase("$100", boldTableFont));
                        totalAmtCell3.HorizontalAlignment = 1;
                        itemTable.AddCell(totalAmtCell3);
                    }

                    // Table footer
                    {
                        PdfPCell totalAmtStrCell = new PdfPCell(new Phrase("Total Amount", boldTableFont));
                        totalAmtStrCell.Border = Rectangle.NO_BORDER;   //Rectangle.NO_BORDER; //Rectangle.TOP_BORDER;
                        totalAmtStrCell.HorizontalAlignment = 1;
                        totalAmtStrCell.Colspan = 2;
                        itemTable.AddCell(totalAmtStrCell);
                        PdfPCell totalAmtCell = new PdfPCell(new Phrase("10", boldTableFont));
                        totalAmtCell.HorizontalAlignment = 1;
                        totalAmtCell.BackgroundColor = TabelHeaderBackGroundColor;
                        totalAmtCell.Border = Rectangle.NO_BORDER;
                        itemTable.AddCell(totalAmtCell);
                        PdfPCell totalAmtCell3 = new PdfPCell(new Phrase("$100", boldTableFont));
                        totalAmtCell3.HorizontalAlignment = 1;
                        totalAmtCell3.BackgroundColor = TabelHeaderBackGroundColor;
                        totalAmtCell3.Border = Rectangle.NO_BORDER;
                        itemTable.AddCell(totalAmtCell3);
                    }
                    document.Add(itemTable);


                }


                document.NewPage();


                // Header 
                {
                    PdfPTable headerT = new PdfPTable(3);
                    PdfPCell cell = new PdfPCell(new Phrase(""));

                    cell.Colspan = 3;

                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    cell.Border = Rectangle.NO_BORDER;
                    headerT.AddCell(cell);

                    float[] widths = new float[] { 2f, 4f, 6f };

                    headerT.SetWidths(widths);
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    headerT.WidthPercentage = 100;
                    headerT.SetWidths(new float[] { 300f, 100f, 150f });  // then set the column's __relative__ widths
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    string[] headerInfo = new string[] { "Activity Date: 7 / 9/ 2018", "", "Claim Number: 12345",
                                                    "Invoice Date: June 2, 2018"," ", "Provider File# JOD"};

                    foreach (string str in headerInfo)
                    {
                        PdfPCell cell1 = new PdfPCell(new Phrase(str, boldTableFont));
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        cell1.Border = Rectangle.NO_BORDER;
                        headerT.AddCell(cell1);
                    }

                    headerT.PaddingTop = 10F;

                    document.Add(headerT);

                }

                // Space 
                {
                    Paragraph title = new Paragraph();
                    title.Add("\n");
                    document.Add(title);
                }

                // Header 
                {
                    PdfPTable headerT = new PdfPTable(3);
                    PdfPCell cell = new PdfPCell(new Phrase(""));

                    cell.Colspan = 3;

                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    cell.Border = Rectangle.NO_BORDER;
                    headerT.AddCell(cell);

                    float[] widths = new float[] { 2f, 4f, 6f };

                    headerT.SetWidths(widths);
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    headerT.WidthPercentage = 100;
                    headerT.SetWidths(new float[] { 300f, 100f, 150f });  // then set the column's __relative__ widths
                    headerT.DefaultCell.Border = Rectangle.NO_BORDER;

                    string[] headerInfo = new string[] { "INSURER: Blue Cross", "", "EMPLOYEE: Joe Dirt",
                                                    "PROVIDER: Comapny Name"," ", "REG# 1234"};

                    foreach (string str in headerInfo)
                    {
                        PdfPCell cell1 = new PdfPCell(new Phrase(str, boldTableFont));
                        cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                        cell1.Border = Rectangle.NO_BORDER;
                        headerT.AddCell(cell1);
                    }

                    headerT.PaddingTop = 10F;

                    document.Add(headerT);

                }

                // Space 
                {
                    Paragraph title = new Paragraph();
                    title.Add("\n");
                    document.Add(title);
                }

                // Title 
                {
                    Paragraph title = new Paragraph();
                    title.Alignment = Element.ALIGN_CENTER;
                    title.Font = FontFactory.GetFont("Arial", 18, Font.BOLD);
                    title.Add("\nVocational Rehabilitation Services");
                    document.Add(title);

                }

                // Space 
                {
                    Paragraph title = new Paragraph();
                    title.Add("\n");
                    document.Add(title);
                }

                // Tabel 
                {

                    //Create body table
                    PdfPTable itemTable = new PdfPTable(7);

                    itemTable.HorizontalAlignment = 0;
                    itemTable.WidthPercentage = 100;
                    itemTable.SetWidths(new float[] { 5, 15, 40, 10, 10, 10, 10});  // then set the column's __relative__ widths
                    itemTable.SpacingAfter = 40;
                    itemTable.DefaultCell.Border = Rectangle.BOX;
                    PdfPCell cell1 = new PdfPCell(new Phrase("NO", boldTableFont));
                    cell1.BackgroundColor = TabelHeaderBackGroundColor;
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell1);
                    PdfPCell cell5 = new PdfPCell(new Phrase("DATE OF SERVICES", boldTableFont));
                    cell5.BackgroundColor = TabelHeaderBackGroundColor;
                    cell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell5);
                    PdfPCell cell2 = new PdfPCell(new Phrase("DESCRIPTION", boldTableFont));
                    cell2.BackgroundColor = TabelHeaderBackGroundColor;
                    cell2.HorizontalAlignment = 1;
                    itemTable.AddCell(cell2);
                    PdfPCell cell3 = new PdfPCell(new Phrase("CODE", boldTableFont));
                    cell3.BackgroundColor = TabelHeaderBackGroundColor;
                    cell3.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell3);
                    PdfPCell cell4 = new PdfPCell(new Phrase("TIME", boldTableFont));
                    cell4.BackgroundColor = TabelHeaderBackGroundColor;
                    cell4.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell4);
                    PdfPCell cell6 = new PdfPCell(new Phrase("MILEAGE", boldTableFont));
                    cell6.BackgroundColor = TabelHeaderBackGroundColor;
                    cell6.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell6);
                    PdfPCell cell7 = new PdfPCell(new Phrase("Expense", boldTableFont));
                    cell7.BackgroundColor = TabelHeaderBackGroundColor;
                    cell7.HorizontalAlignment = Element.ALIGN_CENTER;
                    itemTable.AddCell(cell7);

                    //foreach (DataRow row in dt.Rows)
                    {
                        PdfPCell numberCell = new PdfPCell(new Phrase("1", bodyFont));
                        numberCell.HorizontalAlignment = 1;
                        numberCell.PaddingLeft = 10f;
                        itemTable.AddCell(numberCell);

                        var _phrase = new Phrase();
                        _phrase.Add(new Chunk("04/01/2017", bodyFont));
                        PdfPCell descCell = new PdfPCell(_phrase);
                        descCell.HorizontalAlignment = 1;
                        descCell.PaddingLeft = 10f;
                        itemTable.AddCell(descCell);

                        PdfPCell qtyCell = new PdfPCell(new Phrase("Job Development", bodyFont));
                        qtyCell.HorizontalAlignment = 1;
                        qtyCell.PaddingLeft = 10f;
                        itemTable.AddCell(qtyCell);

                        PdfPCell amountCell = new PdfPCell(new Phrase("10", bodyFont));
                        amountCell.HorizontalAlignment = 1;
                        amountCell.PaddingLeft = 10f;
                        itemTable.AddCell(amountCell);

                        PdfPCell totalamtCell = new PdfPCell(new Phrase("5", bodyFont));
                        totalamtCell.HorizontalAlignment = 1;
                        itemTable.AddCell(totalamtCell);

                        PdfPCell mileageamtCell = new PdfPCell(new Phrase("76", bodyFont));
                        mileageamtCell.HorizontalAlignment = 1;
                        itemTable.AddCell(mileageamtCell);

                        PdfPCell expamtCell = new PdfPCell(new Phrase("76", bodyFont));
                        expamtCell.HorizontalAlignment = 1;
                        itemTable.AddCell(expamtCell);

                    }
        
                    document.Add(itemTable);


                }
            


                document.Close();
           
                System.Diagnostics.Process.Start("C:\\Users\\chris\\Documents\\Projects\\BusinessInvoiceApplication\\BusinessInvoiceApp\\Invoice\\bin\\Debug\\Chapter1_Example1.pdf");
            }
            catch
            {

            }
   
        }



    }
}
