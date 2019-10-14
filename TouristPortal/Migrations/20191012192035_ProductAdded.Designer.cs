﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TouristPortal.Models;

namespace TouristPortal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191012192035_ProductAdded")]
    partial class ProductAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TouristPortal.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Morze",
                            Description = "Realizujemy wycieczki nad morze, nie tylko latem, ale także w pozostałe pory roku."
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Ocean",
                            Description = "4 oceany do twojej dyspozycji."
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Góry",
                            Description = "Gimalai czy Alpy? A może od razu Everest? Potrafimy realizować wszystko"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Kultura",
                            Description = "Zobacz z nami 5 kontynentów świata"
                        });
                });

            modelBuilder.Entity("TouristPortal.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfMonth")
                        .HasColumnType("bit");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Country = "Włochy",
                            ImageUrl = "http://robertofranco.pl/Diploma/Marsala.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/MarsalaLogo.jpg",
                            LongDescription = "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa. Miłośnicy kite i windsurfingu przyjeżdżają w te okolice, by złapać wiatr w żagle (i latawce) na zatoce Lo Stagnone. Inni kojarzą Marsalę z winem o identycznej nazwie. ",
                            MapX = "37.796355",
                            MapY = "12.430414",
                            Name = "Marsala",
                            Price = 2548.00m,
                            ShortDescription = "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa",
                            Time = "7 dni"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Country = "Portugalia",
                            ImageUrl = "http://robertofranco.pl/Diploma/Peniche.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/PenicheLogo.jpg",
                            LongDescription = "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją. W miasteczku jest wiele bardzo lokalnych zakątków, gdzie możesz poobserwować powolne, niespieszne życie Portugalczyków. Widoki są cudowne, jedzenie pyszne i tanie i łatwo się tam też dostać. Nie pożałujesz odwiedzin w Peniche.",
                            MapX = "39.361309",
                            MapY = "-9.396556",
                            Name = "Peniche",
                            Price = 3179.00m,
                            ShortDescription = "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją.",
                            Time = "6 dni"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            Country = "Nepal",
                            ImageUrl = "http://robertofranco.pl/Diploma/Everest.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/EverestLogo.jpg",
                            LongDescription = "Najwyższa góra świata, zaliczana do 'Korony Himalajów' oraz 'Korony Ziemi', najwyższych szczytów wszystkich kontynentów.Mount Everest jest nadal poważną i groźną górą jak każdy zdobywany 8-tysięcznik. Brak tlenu, zimno, załamania pogody, to konkretne przeszkody w zdobywaniu tej góry. Oprócz tego niewielkie trudności techniczne: porusznie się po linach poręczowych, przechodzenie ścian lodowych czy barier skalnych. ",
                            MapX = "27.988076",
                            MapY = "86.924930",
                            Name = "Everest",
                            Price = 80000.00m,
                            ShortDescription = "Najwyższy szczyt Ziemi, ośmiotysięcznik położony w Himalajach Wysokich",
                            Time = "45 dni"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Country = "Sri Lanka",
                            ImageUrl = "http://robertofranco.pl/Diploma/sriLanka.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/sriLankaLogo.jpg",
                            LongDescription = "Cywilizacja na wyspie istnieje już od VI stulecia p.n.e. Zarówno obecna stolica kraju – Kolombo, jak i dawna – Kandy przyciągają co roku rzesze turystów. Innymi ważnymi miastami są dawne stolice lokalnych królestw - Anuradhapura i Polonnaruwa. Oprócz atrakcji historycznych warto również przyjrzeć się nieco tutejszej, niezwykle bogatej faunie i florze. Skosztowanie oryginalnej cejlońskiej herbaty jest niemal obowiązkowym punktem podczas pobytu na Sri Lance. Ciepły klimat, szerokie, piaszczyste plaże, krystalicznie czysta woda oraz gościnność mieszkańców wyspy z pewnością przyczynią się do udanego wyjazdu.",
                            MapX = "7.607707",
                            MapY = "81.138021",
                            Name = "Sri Lanka",
                            Price = 8080.00m,
                            ShortDescription = "Sri Lanka, zwana również „Perłą Oceanu Indyjskiego”, położona jest w Azji Południowej, na wyspie Cejlon.",
                            Time = "8 dni"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 4,
                            Country = "Włochy",
                            ImageUrl = "http://robertofranco.pl/Diploma/Florencja.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/FlorencjaLogo.jpg",
                            LongDescription = "Florencja to worek z prezentami, który nie ma dna. Za każdym winklem mówi nam 'dzień dobry' podręcznik do historii sztuki. Olśniewający kościół przy kameralnym placu. Rzeźba świętego Sebastiana, przebitego strzałami, schowana za szkłem we wnęce niepozornego domu. Przepiękne obrazy-ołtarzyki wmurowane w fasady. Wspaniałe rzeźbione klamki. Potężne, bogato zdobione drzwi do liczących setki lat kamienic. Co kilkadziesiąt metrów zabytek najwyższej klasy. Klęska urodzaju!",
                            MapX = "43.769546",
                            MapY = "11.246303",
                            Name = "Florencja",
                            Price = 1530.00m,
                            ShortDescription = "We Florencji jest tyle miejsc wartych zobaczenia, że z powodzeniem można by spędzić tu cały urlop",
                            Time = "3 dni"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 4,
                            Country = "Anglia",
                            ImageUrl = "http://robertofranco.pl/Diploma/Londyn.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/LondynLogo.jpg",
                            LongDescription = "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu. Centrum finansowe, kulturalne i rozrywkowe. Jedno z najchętniej odwiedzanych przez turystów miast świata. Raj dla wielbicieli historii, mody i... rodziny królewskiej. Nie można się pomylić, witamy w Londynie. ",
                            MapX = "51.508446",
                            MapY = "-0.116720",
                            Name = "Londyn",
                            Price = 2100.00m,
                            ShortDescription = "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu",
                            Time = "2 dni"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Country = "Egipt",
                            ImageUrl = "http://robertofranco.pl/Diploma/Hurghada.jpg",
                            InStock = true,
                            IsProductOfMonth = false,
                            LogoUrl = "http://robertofranco.pl/Diploma/HurghadaLogo.jpg",
                            LongDescription = "Hurghada to jeden z najpopularniejszych wakacyjnych kierunków w Egipcie. Miasto to stale się rozwija, kusząc turystów bogatą ofertą możliwości do odpoczynku i nurkowania. Poza tym warto odwiedzić pobliskie sklepy i bazary, których wiele można spotkać w tamtej okolicy.",
                            MapX = "27.263904",
                            MapY = "33.812615",
                            Name = "Hurghada",
                            Price = 2000.00m,
                            ShortDescription = "Hurghada Egipt zachwyca bajkowymi rafami koralowymi, ale i kawałkiem starożytnej historii.",
                            Time = "9 dni"
                        });
                });

            modelBuilder.Entity("TouristPortal.Models.Product", b =>
                {
                    b.HasOne("TouristPortal.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
