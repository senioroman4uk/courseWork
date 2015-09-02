﻿using System;
using System.Text;
using CAccounts;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace ServiceClasses
{
    public class DocumentPrinter
    {
        private const string openXmlCode1 =
            @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
            <?mso-application progid=""Word.Document""?>
            <w:document xmlns:ve=""http://schemas.openxmlformats.org/markup-compatibility/2006"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:m=""http://schemas.openxmlformats.org/officeDocument/2006/math"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:wp=""http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing"" xmlns:w10=""urn:schemas-microsoft-com:office:word"" xmlns:w=""http://schemas.openxmlformats.org/wordprocessingml/2006/main"" xmlns:wne=""http://schemas.microsoft.com/office/word/2006/wordml"">
            <w:body><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:lastRenderedPageBreak/><w:t>Завідуючому кафедрою АСОІУ</w:t></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/>
            <w:t>О. А. Павлову</w:t></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/><w:t>студента групи {0} курсу {1}</w:t></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/><w:t>{2}</w:t></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/><w:t>{3}</w:t></w:r></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:sectPr w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidSect=""004118B7""><w:pgSz w:w=""11906"" w:h=""16838""/><w:pgMar w:top=""1440"" w:right=""1440"" w:bottom=""1440"" w:left=""1440"" w:header=""708"" w:footer=""708"" w:gutter=""0""/><w:cols w:num=""2"" w:space=""708""/><w:docGrid w:linePitch=""360""/></w:sectPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/>
            <w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:jc w:val=""center""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:b/><w:i/><w:sz w:val=""28""/><w:szCs w:val=""28""/></w:rPr></w:pPr><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:b/><w:i/><w:sz w:val=""28""/><w:szCs w:val=""28""/></w:rPr><w:t>ЗАЯВА</w:t></w:r></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:jc w:val=""center""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>Прошу затвердити тему мого дипломного проекту:</w:t></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/>
            <w:szCs w:val=""24""/></w:rPr><w:br/><w:t>«{4}».</w:t></w:r><w:r w:rsidR=""00BB2A27"" w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t xml:space=""preserve""> </w:t></w:r></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/>
            <w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:sectPr w:rsidR=""00BB2A27"" w:rsidSect=""004118B7""><w:type w:val=""continuous""/><w:pgSz w:w=""11906"" w:h=""16838""/><w:pgMar w:top=""1440"" w:right=""1440"" w:bottom=""1440"" w:left=""1440"" w:header=""708"" w:footer=""708"" w:gutter=""0""/><w:cols w:space=""708""/><w:docGrid w:linePitch=""360""/></w:sectPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00942991"" w:rsidRDefault=""00942991"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/>
            <w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>{5}</w:t></w:r></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00BB2A27"" w:rsidRDefault=""004118B7"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>Керівник проекту</w:t></w:r><w:r w:rsidR=""00942991""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/></w:r><w:r w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>{6}</w:t></w:r></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00BB2A27"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00942991"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/>
            <w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/></w:r></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00942991"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:lastRenderedPageBreak/><w:br/></w:r></w:p><w:p w:rsidR=""00BB2A27"" w:rsidRDefault=""00794D5F"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:jc w:val=""center""/><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr></w:pPr><w:r w:rsidRPr=""00794D5F""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:noProof/><w:sz w:val=""24""/><w:szCs w:val=""24""/><w:lang w:val=""en-GB"" w:eastAsia=""en-GB""/></w:rPr><w:pict><v:shapetype id=""_x0000_t32"" coordsize=""21600,21600"" o:spt=""32"" o:oned=""t"" path=""m,l21600,21600e"" filled=""f""><v:path arrowok=""t"" fillok=""f"" o:connecttype=""none""/><o:lock v:ext=""edit"" shapetype=""t""/></v:shapetype><v:shape id=""_x0000_s1027"" type=""#_x0000_t32"" style=""position:absolute;left:0;text-align:left;margin-left:33.95pt;margin-top:16.25pt;width:144.2pt;height:.05pt;flip:x;z-index:251658240"" o:connectortype=""straight""/></w:pict></w:r><w:r w:rsidR=""004118B7"" w:rsidRPr=""00942991""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>{7}</w:t></w:r><w:r w:rsidR=""00942991""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/>
            <w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/></w:r><w:r w:rsidR=""00BB2A27"" w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""20""/><w:szCs w:val=""20""/></w:rPr><w:t>Підпис</w:t></w:r></w:p><w:p w:rsidR=""004118B7"" w:rsidRPr=""00942991"" w:rsidRDefault=""00794D5F"" w:rsidP=""00942991""><w:pPr><w:tabs><w:tab w:val=""left"" w:pos=""3405""/></w:tabs><w:spacing w:line=""360"" w:lineRule=""auto""/><w:jc w:val=""center""/></w:pPr><w:r w:rsidRPr=""00794D5F""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:noProof/><w:sz w:val=""24""/><w:szCs w:val=""24""/><w:lang w:val=""en-GB"" w:eastAsia=""en-GB""/></w:rPr><w:pict><v:shape id=""_x0000_s1029"" type=""#_x0000_t32"" style=""position:absolute;left:0;text-align:left;margin-left:34.75pt;margin-top:15.95pt;width:143.4pt;height:.05pt;flip:x;z-index:251659264"" o:connectortype=""straight""/></w:pict></w:r><w:r w:rsidR=""004118B7"" w:rsidRPr=""00942991""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:t>{8}</w:t></w:r><w:r w:rsidR=""00942991""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""24""/><w:szCs w:val=""24""/></w:rPr><w:br/></w:r><w:r w:rsidR=""00942991"" w:rsidRPr=""00BB2A27""><w:rPr><w:rFonts w:ascii=""Times New Roman"" w:hAnsi=""Times New Roman"" w:cs=""Times New Roman""/><w:i/><w:sz w:val=""20""/><w:szCs w:val=""20""/></w:rPr><w:t>Підпис</w:t></w:r></w:p><w:sectPr w:rsidR=""004118B7"" w:rsidRPr=""00942991"" w:rsidSect=""00BB2A27""><w:type w:val=""continuous""/><w:pgSz w:w=""11906"" w:h=""16838""/><w:pgMar w:top=""1440"" w:right=""1440"" w:bottom=""1440"" w:left=""1440"" w:header=""708"" w:footer=""708"" w:gutter=""0""/><w:cols w:num=""2"" w:space=""708""/><w:docGrid w:linePitch=""360""/></w:sectPr></w:body></w:document>";


        public static void ProjectThemeApproving(Student studentInfo, string projectTitle, string projectManager, string path)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document))
            {
                // Set the content of the document so that Word can open it.
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                using (Stream stream = mainPart.GetStream())
                {
                    string formatted = string.Format(openXmlCode1, studentInfo.Group, 2, studentInfo.Faculty,
                        studentInfo.Lastname + " " + studentInfo.Firstname + " " + studentInfo.Patronymic,
                        projectTitle, DateTime.Today.ToShortDateString(), DateTime.Today.ToShortDateString(),
                        studentInfo.Fullname, projectManager);
                    byte[] buf = (new UTF8Encoding()).GetBytes(formatted);
                    stream.Write(buf, 0, buf.Length);
                }
            }
        }
    }
}
