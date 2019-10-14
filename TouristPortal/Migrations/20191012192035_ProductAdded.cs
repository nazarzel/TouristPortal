using Microsoft.EntityFrameworkCore.Migrations;

namespace TouristPortal.Migrations
{
    public partial class ProductAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Morze", "Realizujemy wycieczki nad morze, nie tylko latem, ale także w pozostałe pory roku." },
                    { 2, "Ocean", "4 oceany do twojej dyspozycji." },
                    { 3, "Góry", "Gimalai czy Alpy? A może od razu Everest? Potrafimy realizować wszystko" },
                    { 4, "Kultura", "Zobacz z nami 5 kontynentów świata" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Country", "ImageUrl", "InStock", "IsProductOfMonth", "LogoUrl", "LongDescription", "MapX", "MapY", "Name", "Price", "ShortDescription", "Time" },
                values: new object[,]
                {
                    { 1, 1, "Włochy", "http://robertofranco.pl/Diploma/Marsala.jpg", true, false, "http://robertofranco.pl/Diploma/MarsalaLogo.jpg", "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa. Miłośnicy kite i windsurfingu przyjeżdżają w te okolice, by złapać wiatr w żagle (i latawce) na zatoce Lo Stagnone. Inni kojarzą Marsalę z winem o identycznej nazwie. ", "37.796355", "12.430414", "Marsala", 2548.00m, "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa", "7 dni" },
                    { 7, 1, "Egipt", "http://robertofranco.pl/Diploma/Hurghada.jpg", true, false, "http://robertofranco.pl/Diploma/HurghadaLogo.jpg", "Hurghada to jeden z najpopularniejszych wakacyjnych kierunków w Egipcie. Miasto to stale się rozwija, kusząc turystów bogatą ofertą możliwości do odpoczynku i nurkowania. Poza tym warto odwiedzić pobliskie sklepy i bazary, których wiele można spotkać w tamtej okolicy.", "27.263904", "33.812615", "Hurghada", 2000.00m, "Hurghada Egipt zachwyca bajkowymi rafami koralowymi, ale i kawałkiem starożytnej historii.", "9 dni" },
                    { 2, 2, "Portugalia", "http://robertofranco.pl/Diploma/Peniche.jpg", true, false, "http://robertofranco.pl/Diploma/PenicheLogo.jpg", "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją. W miasteczku jest wiele bardzo lokalnych zakątków, gdzie możesz poobserwować powolne, niespieszne życie Portugalczyków. Widoki są cudowne, jedzenie pyszne i tanie i łatwo się tam też dostać. Nie pożałujesz odwiedzin w Peniche.", "39.361309", "-9.396556", "Peniche", 3179.00m, "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją.", "6 dni" },
                    { 4, 2, "Sri Lanka", "http://robertofranco.pl/Diploma/sriLanka.jpg", true, false, "http://robertofranco.pl/Diploma/sriLankaLogo.jpg", "Cywilizacja na wyspie istnieje już od VI stulecia p.n.e. Zarówno obecna stolica kraju – Kolombo, jak i dawna – Kandy przyciągają co roku rzesze turystów. Innymi ważnymi miastami są dawne stolice lokalnych królestw - Anuradhapura i Polonnaruwa. Oprócz atrakcji historycznych warto również przyjrzeć się nieco tutejszej, niezwykle bogatej faunie i florze. Skosztowanie oryginalnej cejlońskiej herbaty jest niemal obowiązkowym punktem podczas pobytu na Sri Lance. Ciepły klimat, szerokie, piaszczyste plaże, krystalicznie czysta woda oraz gościnność mieszkańców wyspy z pewnością przyczynią się do udanego wyjazdu.", "7.607707", "81.138021", "Sri Lanka", 8080.00m, "Sri Lanka, zwana również „Perłą Oceanu Indyjskiego”, położona jest w Azji Południowej, na wyspie Cejlon.", "8 dni" },
                    { 3, 3, "Nepal", "http://robertofranco.pl/Diploma/Everest.jpg", true, false, "http://robertofranco.pl/Diploma/EverestLogo.jpg", "Najwyższa góra świata, zaliczana do 'Korony Himalajów' oraz 'Korony Ziemi', najwyższych szczytów wszystkich kontynentów.Mount Everest jest nadal poważną i groźną górą jak każdy zdobywany 8-tysięcznik. Brak tlenu, zimno, załamania pogody, to konkretne przeszkody w zdobywaniu tej góry. Oprócz tego niewielkie trudności techniczne: porusznie się po linach poręczowych, przechodzenie ścian lodowych czy barier skalnych. ", "27.988076", "86.924930", "Everest", 80000.00m, "Najwyższy szczyt Ziemi, ośmiotysięcznik położony w Himalajach Wysokich", "45 dni" },
                    { 5, 4, "Włochy", "http://robertofranco.pl/Diploma/Florencja.jpg", true, false, "http://robertofranco.pl/Diploma/FlorencjaLogo.jpg", "Florencja to worek z prezentami, który nie ma dna. Za każdym winklem mówi nam 'dzień dobry' podręcznik do historii sztuki. Olśniewający kościół przy kameralnym placu. Rzeźba świętego Sebastiana, przebitego strzałami, schowana za szkłem we wnęce niepozornego domu. Przepiękne obrazy-ołtarzyki wmurowane w fasady. Wspaniałe rzeźbione klamki. Potężne, bogato zdobione drzwi do liczących setki lat kamienic. Co kilkadziesiąt metrów zabytek najwyższej klasy. Klęska urodzaju!", "43.769546", "11.246303", "Florencja", 1530.00m, "We Florencji jest tyle miejsc wartych zobaczenia, że z powodzeniem można by spędzić tu cały urlop", "3 dni" },
                    { 6, 4, "Anglia", "http://robertofranco.pl/Diploma/Londyn.jpg", true, false, "http://robertofranco.pl/Diploma/LondynLogo.jpg", "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu. Centrum finansowe, kulturalne i rozrywkowe. Jedno z najchętniej odwiedzanych przez turystów miast świata. Raj dla wielbicieli historii, mody i... rodziny królewskiej. Nie można się pomylić, witamy w Londynie. ", "51.508446", "-0.116720", "Londyn", 2100.00m, "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu", "2 dni" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
