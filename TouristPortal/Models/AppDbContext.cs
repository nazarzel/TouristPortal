﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TouristPortal.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Morze", Description = "Realizujemy wycieczki nad morze, nie tylko latem, ale także w pozostałe pory roku." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Ocean", Description = "4 oceany do twojej dyspozycji." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Góry", Description = "Gimalai czy Alpy? A może od razu Everest? Potrafimy realizować wszystko" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Kultura", Description = "Zobacz z nami 5 kontynentów świata" });

            //seed products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Marsala",
                Country = "Włochy",
                Time = "7 dni",
                Price = 2548.00M,
                ShortDescription = "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa",
                LongDescription = "Oddalona o kilkanaście kilometrów od lotniska w Trapani Marsala sama w sobie jest bardzo ciekawa. Miłośnicy kite i windsurfingu przyjeżdżają w te okolice, by złapać wiatr w żagle (i latawce) na zatoce Lo Stagnone. Inni kojarzą Marsalę z winem o identycznej nazwie. ",
                CategoryId = 1,
                ImageUrl = "http://robertofranco.pl/Diploma/Marsala.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/MarsalaLogo.jpg",
                MapX = "37.796355",
                MapY = "12.430414"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Peniche",
                Country = "Portugalia",
                Time = "6 dni",
                Price = 3179.00M,
                ShortDescription = "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją.",
                LongDescription = "Jeżeli szukasz miejsca na krótką wycieczkę poza Lizbonę, to Peniche będzie doskonałą opcją. W miasteczku jest wiele bardzo lokalnych zakątków, gdzie możesz poobserwować powolne, niespieszne życie Portugalczyków. Widoki są cudowne, jedzenie pyszne i tanie i łatwo się tam też dostać. Nie pożałujesz odwiedzin w Peniche.",
                CategoryId = 2,
                ImageUrl = "http://robertofranco.pl/Diploma/Peniche.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/PenicheLogo.jpg",
                MapX = "39.361309",
                MapY = "-9.396556"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Everest",
                Country = "Nepal",
                Time = "45 dni",
                Price = 80000.00M,
                ShortDescription = "Najwyższy szczyt Ziemi, ośmiotysięcznik położony w Himalajach Wysokich",
                LongDescription = "Najwyższa góra świata, zaliczana do 'Korony Himalajów' oraz 'Korony Ziemi', najwyższych szczytów wszystkich kontynentów.Mount Everest jest nadal poważną i groźną górą jak każdy zdobywany 8-tysięcznik. Brak tlenu, zimno, załamania pogody, to konkretne przeszkody w zdobywaniu tej góry. Oprócz tego niewielkie trudności techniczne: porusznie się po linach poręczowych, przechodzenie ścian lodowych czy barier skalnych. ",
                CategoryId = 3,
                ImageUrl = "http://robertofranco.pl/Diploma/Everest.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/EverestLogo.jpg",
                MapX = "27.988076",
                MapY = "86.924930"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Sri Lanka",
                Country = "Sri Lanka",
                Time = "8 dni",
                Price = 8080.00M,
                ShortDescription = "Sri Lanka, zwana również „Perłą Oceanu Indyjskiego”, położona jest w Azji Południowej, na wyspie Cejlon.",
                LongDescription = "Cywilizacja na wyspie istnieje już od VI stulecia p.n.e. Zarówno obecna stolica kraju – Kolombo, jak i dawna – Kandy przyciągają co roku rzesze turystów. Innymi ważnymi miastami są dawne stolice lokalnych królestw - Anuradhapura i Polonnaruwa. Oprócz atrakcji historycznych warto również przyjrzeć się nieco tutejszej, niezwykle bogatej faunie i florze. Skosztowanie oryginalnej cejlońskiej herbaty jest niemal obowiązkowym punktem podczas pobytu na Sri Lance. Ciepły klimat, szerokie, piaszczyste plaże, krystalicznie czysta woda oraz gościnność mieszkańców wyspy z pewnością przyczynią się do udanego wyjazdu.",
                CategoryId = 2,
                ImageUrl = "http://robertofranco.pl/Diploma/sriLanka.jpg",
                InStock = true,
                IsProductOfMonth = false,
                LogoUrl = "http://robertofranco.pl/Diploma/sriLankaLogo.jpg",
                MapX = "7.607707",
                MapY = "81.138021"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Florencja",
                Country = "Włochy",
                Time = "3 dni",
                Price = 1530.00M,
                ShortDescription = "We Florencji jest tyle miejsc wartych zobaczenia, że z powodzeniem można by spędzić tu cały urlop",
                LongDescription = "Florencja to worek z prezentami, który nie ma dna. Za każdym winklem mówi nam 'dzień dobry' podręcznik do historii sztuki. Olśniewający kościół przy kameralnym placu. Rzeźba świętego Sebastiana, przebitego strzałami, schowana za szkłem we wnęce niepozornego domu. Przepiękne obrazy-ołtarzyki wmurowane w fasady. Wspaniałe rzeźbione klamki. Potężne, bogato zdobione drzwi do liczących setki lat kamienic. Co kilkadziesiąt metrów zabytek najwyższej klasy. Klęska urodzaju!",
                CategoryId = 4,
                ImageUrl = "http://robertofranco.pl/Diploma/Florencja.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/FlorencjaLogo.jpg",
                MapX = "43.769546",
                MapY = "11.246303"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Londyn",
                Country = "Anglia",
                Time = "2 dni",
                Price = 2100.00M,
                ShortDescription = "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu",
                LongDescription = "Trzecie co wielkości miasto Europy i, jak mówi wielu, stolica całego kontynentu. Centrum finansowe, kulturalne i rozrywkowe. Jedno z najchętniej odwiedzanych przez turystów miast świata. Raj dla wielbicieli historii, mody i... rodziny królewskiej. Nie można się pomylić, witamy w Londynie. ",
                CategoryId = 4,
                ImageUrl = "http://robertofranco.pl/Diploma/Londyn.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/LondynLogo.jpg",
                MapX = "51.508446",
                MapY = "-0.116720"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Hurghada",
                Country = "Egipt",
                Time = "9 dni",
                Price = 2000.00M,
                ShortDescription = "Hurghada Egipt zachwyca bajkowymi rafami koralowymi, ale i kawałkiem starożytnej historii.",
                LongDescription = "Hurghada to jeden z najpopularniejszych wakacyjnych kierunków w Egipcie. Miasto to stale się rozwija, kusząc turystów bogatą ofertą możliwości do odpoczynku i nurkowania. Poza tym warto odwiedzić pobliskie sklepy i bazary, których wiele można spotkać w tamtej okolicy.",
                CategoryId = 1,
                ImageUrl = "http://robertofranco.pl/Diploma/Hurghada.jpg",
                InStock = true,
                IsProductOfMonth = true,
                LogoUrl = "http://robertofranco.pl/Diploma/HurghadaLogo.jpg",
                MapX = "27.263904",
                MapY = "33.812615"
            });
        }
    }
}
