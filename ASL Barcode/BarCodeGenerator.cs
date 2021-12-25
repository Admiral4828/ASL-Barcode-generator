using System;
using System.Collections.Generic;

namespace ASL_Barcode
{
    public class BarCodeGenerator
    {
        public static List<KeyValuePair<string, string>> lstOlkeler = new List<KeyValuePair<string, string>>();
        public static string Barkod;
        public void BarkodHazirla_EAN13(string OlkeKodu, string IstehsalciKodu)
        {
            Random rnd = new Random();
            int ReqemVer = rnd.Next(10000, 99999);

            string Kod = OlkeKodu + IstehsalciKodu + ReqemVer.ToString();

            int cut1 = int.Parse(Kod.Substring(1, 1));
            int cut2 = int.Parse(Kod.Substring(3, 1));
            int cut3 = int.Parse(Kod.Substring(5, 1));
            int cut4 = int.Parse(Kod.Substring(7, 1));
            int cut5 = int.Parse(Kod.Substring(9, 1));
            int cut6 = int.Parse(Kod.Substring(11, 1));

            int tek1 = int.Parse(Kod.Substring(0, 1));
            int tek2 = int.Parse(Kod.Substring(2, 1));
            int tek3 = int.Parse(Kod.Substring(4, 1));
            int tek4 = int.Parse(Kod.Substring(6, 1));
            int tek5 = int.Parse(Kod.Substring(8, 1));
            int tek6 = int.Parse(Kod.Substring(10, 1));
            
            int cutler = cut1 + cut2 + cut3 + cut4 + cut5 + cut6;
            int tekler = tek1 + tek2 + tek3 + tek4 + tek5 + tek6;

            int Hesab1 = cutler * 3;
            int Hesab2 = Hesab1 + tekler;
            
            string HesabUzunlugu = Hesab2.ToString();
            int SonReqem = 0;
            
            if (HesabUzunlugu.Length == 3)
            {
                SonReqem = int.Parse(HesabUzunlugu.Substring(2, 1));
            }
            if (HesabUzunlugu.Length == 2)
            {
                SonReqem = int.Parse(HesabUzunlugu.Substring(1, 1));
            }

            int NezaretKodu = 10 - SonReqem;

            Barkod = Kod + NezaretKodu.ToString();
        }
        public void OlkeSiyahisi()
        {
            lstOlkeler.Add(new KeyValuePair<string, string>("000 ABŞ", "000"));
            lstOlkeler.Add(new KeyValuePair<string, string>("139 ABŞ", "139"));
            lstOlkeler.Add(new KeyValuePair<string, string>("200 Daxili nömrələmə", "200"));
            lstOlkeler.Add(new KeyValuePair<string, string>("299 Daxili nömrələmə", "299"));
            lstOlkeler.Add(new KeyValuePair<string, string>("300 Fransa", "300"));
            lstOlkeler.Add(new KeyValuePair<string, string>("379 Fransa", "379"));
            lstOlkeler.Add(new KeyValuePair<string, string>("380 Bolqarıstan", "380"));
            lstOlkeler.Add(new KeyValuePair<string, string>("383 Sloveniya", "383"));
            lstOlkeler.Add(new KeyValuePair<string, string>("385 Xorvatiya", "385"));
            lstOlkeler.Add(new KeyValuePair<string, string>("387 Bosniya və Herseqovina", "387"));
            lstOlkeler.Add(new KeyValuePair<string, string>("400 Almaniya", "400"));
            lstOlkeler.Add(new KeyValuePair<string, string>("440 Almaniya", "440"));
            lstOlkeler.Add(new KeyValuePair<string, string>("450 Yaponiya", "450"));
            lstOlkeler.Add(new KeyValuePair<string, string>("459 Yaponiya", "459"));
            lstOlkeler.Add(new KeyValuePair<string, string>("490 Yaponiya", "490"));
            lstOlkeler.Add(new KeyValuePair<string, string>("499 Yaponiya", "499"));
            lstOlkeler.Add(new KeyValuePair<string, string>("460 Rusiya", "460"));
            lstOlkeler.Add(new KeyValuePair<string, string>("469 Rusiya", "469"));
            lstOlkeler.Add(new KeyValuePair<string, string>("470 Qırğızıstan", "470"));
            lstOlkeler.Add(new KeyValuePair<string, string>("471 Tayvan", "471"));
            lstOlkeler.Add(new KeyValuePair<string, string>("474 Estoniya", "474"));
            lstOlkeler.Add(new KeyValuePair<string, string>("475 Latviya", "475"));
            lstOlkeler.Add(new KeyValuePair<string, string>("476 Azərbaycan", "476"));
            lstOlkeler.Add(new KeyValuePair<string, string>("477 Litva", "477"));
            lstOlkeler.Add(new KeyValuePair<string, string>("478 Özbəkistan", "478"));
            lstOlkeler.Add(new KeyValuePair<string, string>("479 Şri Lanka", "479"));
            lstOlkeler.Add(new KeyValuePair<string, string>("480 Filippin", "480"));
            lstOlkeler.Add(new KeyValuePair<string, string>("481 Belarus", "481"));
            lstOlkeler.Add(new KeyValuePair<string, string>("482 Ukrayna", "482"));
            lstOlkeler.Add(new KeyValuePair<string, string>("484 Moldova", "484"));
            lstOlkeler.Add(new KeyValuePair<string, string>("485 Ermənistan", "485"));
            lstOlkeler.Add(new KeyValuePair<string, string>("486 Gürcüstan", "486"));
            lstOlkeler.Add(new KeyValuePair<string, string>("487 Qazaxıstan", "487"));
            lstOlkeler.Add(new KeyValuePair<string, string>("489 Hong Kong", "489"));
            lstOlkeler.Add(new KeyValuePair<string, string>("500 Böyük Britaniya", "500"));
            lstOlkeler.Add(new KeyValuePair<string, string>("509 Böyük Britaniya", "509"));
            lstOlkeler.Add(new KeyValuePair<string, string>("518 Fil dişi Sahili", "518"));
            lstOlkeler.Add(new KeyValuePair<string, string>("520 Yunanıstan", "520"));
            lstOlkeler.Add(new KeyValuePair<string, string>("528 Livan", "528"));
            lstOlkeler.Add(new KeyValuePair<string, string>("529 Kipr", "529"));
            lstOlkeler.Add(new KeyValuePair<string, string>("530 Albaniya", "530"));
            lstOlkeler.Add(new KeyValuePair<string, string>("531 Makedoniya", "531"));
            lstOlkeler.Add(new KeyValuePair<string, string>("535 Malta", "535"));
            lstOlkeler.Add(new KeyValuePair<string, string>("539 İrlandiya", "539"));
            lstOlkeler.Add(new KeyValuePair<string, string>("540 Belçika, Lüksemburq", "540"));
            lstOlkeler.Add(new KeyValuePair<string, string>("549 Belçika, Lüksemburq", "549"));
            lstOlkeler.Add(new KeyValuePair<string, string>("560 Portuqaliya", "560"));
            lstOlkeler.Add(new KeyValuePair<string, string>("569 İslandiya", "569"));
            lstOlkeler.Add(new KeyValuePair<string, string>("570 Danimarka", "570"));
            lstOlkeler.Add(new KeyValuePair<string, string>("579 Danimarka", "579"));
            lstOlkeler.Add(new KeyValuePair<string, string>("590 Polşa", "590"));
            lstOlkeler.Add(new KeyValuePair<string, string>("594 Rumıniya", "594"));
            lstOlkeler.Add(new KeyValuePair<string, string>("599 Macarıstan", "599"));
            lstOlkeler.Add(new KeyValuePair<string, string>("600 Cənubi Afrika", "600"));
            lstOlkeler.Add(new KeyValuePair<string, string>("601 Cənubi Afrika", "601"));
            lstOlkeler.Add(new KeyValuePair<string, string>("603 Qana", "603"));
            lstOlkeler.Add(new KeyValuePair<string, string>("608 Bəhreyn", "608"));
            lstOlkeler.Add(new KeyValuePair<string, string>("609 Mavriki", "609"));
            lstOlkeler.Add(new KeyValuePair<string, string>("611 Mərakeş", "611"));
            lstOlkeler.Add(new KeyValuePair<string, string>("613 Əlcəzair", "613"));
            lstOlkeler.Add(new KeyValuePair<string, string>("616 Kenya", "616"));
            lstOlkeler.Add(new KeyValuePair<string, string>("619 Tunis", "619"));
            lstOlkeler.Add(new KeyValuePair<string, string>("621 Suriya", "621"));
            lstOlkeler.Add(new KeyValuePair<string, string>("622 Misir", "622"));
            lstOlkeler.Add(new KeyValuePair<string, string>("624 Liviya", "624"));
            lstOlkeler.Add(new KeyValuePair<string, string>("625 İordaniya", "625"));
            lstOlkeler.Add(new KeyValuePair<string, string>("626 İran", "626"));
            lstOlkeler.Add(new KeyValuePair<string, string>("627 Küveyt", "627"));
            lstOlkeler.Add(new KeyValuePair<string, string>("628 Səudiyyə Ərəbistanı", "628"));
            lstOlkeler.Add(new KeyValuePair<string, string>("629 B.Ə.Ə.", "629"));
            lstOlkeler.Add(new KeyValuePair<string, string>("640 Finlandiya", "640"));
            lstOlkeler.Add(new KeyValuePair<string, string>("649 Finlandiya", "649"));
            lstOlkeler.Add(new KeyValuePair<string, string>("690 Çin", "690"));
            lstOlkeler.Add(new KeyValuePair<string, string>("695 Çin", "695"));
            lstOlkeler.Add(new KeyValuePair<string, string>("700 Norveç", "700"));
            lstOlkeler.Add(new KeyValuePair<string, string>("709 Norveç", "709"));
            lstOlkeler.Add(new KeyValuePair<string, string>("729 İsrail", "729"));
            lstOlkeler.Add(new KeyValuePair<string, string>("730 İsveç", "730"));
            lstOlkeler.Add(new KeyValuePair<string, string>("739 İsveç", "739"));
            lstOlkeler.Add(new KeyValuePair<string, string>("741 Salvador", "741"));
            lstOlkeler.Add(new KeyValuePair<string, string>("742 Honduras", "742"));
            lstOlkeler.Add(new KeyValuePair<string, string>("743 Nikaraqua", "743"));
            lstOlkeler.Add(new KeyValuePair<string, string>("744 Kosta Rika", "744"));
            lstOlkeler.Add(new KeyValuePair<string, string>("745 Panama", "745"));
            lstOlkeler.Add(new KeyValuePair<string, string>("746 Dominik Respublikası", "746"));
            lstOlkeler.Add(new KeyValuePair<string, string>("750 Meksika", "750"));
            lstOlkeler.Add(new KeyValuePair<string, string>("754 Kanada", "754"));
            lstOlkeler.Add(new KeyValuePair<string, string>("755 Kanada", "755"));
            lstOlkeler.Add(new KeyValuePair<string, string>("759 Venesuela", "759"));
            lstOlkeler.Add(new KeyValuePair<string, string>("760 İsveçrə", "760"));
            lstOlkeler.Add(new KeyValuePair<string, string>("769 İsveçrə", "769"));
            lstOlkeler.Add(new KeyValuePair<string, string>("770 Kolumbiya", "770"));
            lstOlkeler.Add(new KeyValuePair<string, string>("773 Uruqvay", "773"));
            lstOlkeler.Add(new KeyValuePair<string, string>("775 Peru", "775"));
            lstOlkeler.Add(new KeyValuePair<string, string>("777 Boliviya", "777"));
            lstOlkeler.Add(new KeyValuePair<string, string>("779 Argentina", "779"));
            lstOlkeler.Add(new KeyValuePair<string, string>("780 Çili", "780"));
            lstOlkeler.Add(new KeyValuePair<string, string>("784 Paraqvay", "784"));
            lstOlkeler.Add(new KeyValuePair<string, string>("786 Ekvador", "786"));
            lstOlkeler.Add(new KeyValuePair<string, string>("789 Braziliya", "789"));
            lstOlkeler.Add(new KeyValuePair<string, string>("790 Braziliya", "790"));
            lstOlkeler.Add(new KeyValuePair<string, string>("800 İtaliya", "800"));
            lstOlkeler.Add(new KeyValuePair<string, string>("839 İtaliya", "839"));
            lstOlkeler.Add(new KeyValuePair<string, string>("840 İspaniya", "840"));
            lstOlkeler.Add(new KeyValuePair<string, string>("849 İspaniya", "849"));
            lstOlkeler.Add(new KeyValuePair<string, string>("850 Kuba", "850"));
            lstOlkeler.Add(new KeyValuePair<string, string>("858 Slovakiya", "858"));
            lstOlkeler.Add(new KeyValuePair<string, string>("859 Çexiya", "859"));
            lstOlkeler.Add(new KeyValuePair<string, string>("860 Serbiya və Monteneqro", "860"));
            lstOlkeler.Add(new KeyValuePair<string, string>("865 Monqolustan", "865"));
            lstOlkeler.Add(new KeyValuePair<string, string>("867 Şimali Koreya", "867"));
            lstOlkeler.Add(new KeyValuePair<string, string>("869 Türkiyə", "869"));
            lstOlkeler.Add(new KeyValuePair<string, string>("870 Niderland", "870"));
            lstOlkeler.Add(new KeyValuePair<string, string>("879 Niderland", "879"));
            lstOlkeler.Add(new KeyValuePair<string, string>("880 Cənubi Koreya", "880"));
            lstOlkeler.Add(new KeyValuePair<string, string>("884 Kamboca", "884"));
            lstOlkeler.Add(new KeyValuePair<string, string>("885 Tayland", "885"));
            lstOlkeler.Add(new KeyValuePair<string, string>("888 Sinqapur", "888"));
            lstOlkeler.Add(new KeyValuePair<string, string>("890 Hindistan", "890"));
            lstOlkeler.Add(new KeyValuePair<string, string>("893 Vyetnam", "893"));
            lstOlkeler.Add(new KeyValuePair<string, string>("899 İndoneziya", "899"));
            lstOlkeler.Add(new KeyValuePair<string, string>("900 Avstriya", "900"));
            lstOlkeler.Add(new KeyValuePair<string, string>("919 Avstriya", "919"));
            lstOlkeler.Add(new KeyValuePair<string, string>("930 Avstraliya", "930"));
            lstOlkeler.Add(new KeyValuePair<string, string>("939 Avstraliya", "939"));
            lstOlkeler.Add(new KeyValuePair<string, string>("940 Yeni Zelandiya", "940"));
            lstOlkeler.Add(new KeyValuePair<string, string>("949 Yeni Zelandiya", "949"));
            lstOlkeler.Add(new KeyValuePair<string, string>("950 Baş ofis", "950"));
            lstOlkeler.Add(new KeyValuePair<string, string>("955 Malayziya", "955"));
            lstOlkeler.Add(new KeyValuePair<string, string>("958 Makao", "958"));
            lstOlkeler.Add(new KeyValuePair<string, string>("978 Kitablar (ISBN)", "978"));
            lstOlkeler.Add(new KeyValuePair<string, string>("979 Kitablar(ISBN)", "979"));
            lstOlkeler.Add(new KeyValuePair<string, string>("980 Qaytarılacaq daxilolmalar", "980"));
            lstOlkeler.Add(new KeyValuePair<string, string>("981 Valyuta kuponları", "981"));
            lstOlkeler.Add(new KeyValuePair<string, string>("982 Valyuta kuponları", "982"));
            lstOlkeler.Add(new KeyValuePair<string, string>("990 Kuponla", "990"));
            lstOlkeler.Add(new KeyValuePair<string, string>("999 Kuponla", "999"));
        }
    }
}
