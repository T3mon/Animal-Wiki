﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimaWiki
{


    public partial class MainWindow : Window
    {

        ObservableCollection<Node> nodes;
        public MainWindow()
        {
            InitializeComponent();
            FillTheZoo();
            nodes = new ObservableCollection<Node>
            {
                new Node
                {
                    Name = "poeciloteria",
                    Nodes = new ObservableCollection<Node>
                    {

                    }
                }
            };

        }

        private static void FillTheZoo()
        {
            List<arthropods> animals = new List<arthropods>()
            {
                new poeciloteria
                {
                    name = "poeciloteria regalis",
                    weight = 75,
                    size = 28,
                    price = 600,
                    poison = 8,
                    img = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Poecilotheria_regalis_005.jpg/275px-Poecilotheria_regalis_005.jpg"
                },
                new poeciloteria
                {
                     name = "poeciloteria ornata",
                     weight = 80,
                     size = 30,
                     price = 400,
                     poison = 10,
                     img = " https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Poecilotheria_ornata_-_female_-_top_view.jpg/275px-Poecilotheria_ornata_-_female_-_top_view.jpg"
                },
                new poeciloteria
                {
                     name = "poeciloteria miranda",
                     weight = 70,
                     size = 25,
                     price = 1000,
                     poison = 8,
                     img = "https://www.spidersworld.eu/327/poecilotheria-miranda-25cm-bengal-ornamental.jpg"
                },
                new poeciloteria
                {
                     name = "poeciloteria metallica",
                     color = "blue",
                     weight = 60,
                     size = 19,
                     price = 2500,
                     poison = 10,
                     img = "https://pazitiff.info/uploads/posts/2015-09/1441394009_00fb7d5f3f0f7103a3cdffd2a8a0a14f.jpg"
                },
                new poeciloteria
                {
                     name = "poeciloteria formosa",
                     weight = 70,
                     size = 22,
                     price = 900,
                     poison = 9,
                     img = "https://ah.net.ua/wa-data/public/shop/products/83/46/4683/images/6205/6205.970.jpg"
                },
                new poeciloteria
                {
                     name = "poeciloteria fasciata",
                     weight = 70,
                     size = 20,
                     price = 600,
                     poison = 10,
                     img = "https://lh3.googleusercontent.com/proxy/yS_gphq-o6oW2Bv6uxCPygPjaGLdyYPMj7ePx3f_8Nn1KKmNxaZRss2w1lRQjZOHERLAZIzxelMY5n4W7LAUWNlyrAuvxTVKmK2Sx0yEp1OABOw"
                },
                ////
                new brachypelma
                {
                    name = "poeciloteria regalis",
                    weight = 75,
                    size = 28,
                    price = 600,
                    img = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Poecilotheria_regalis_005.jpg/275px-Poecilotheria_regalis_005.jpg"
                },
                new brachypelma
                {
                     name = "poeciloteria ornata",
                     weight = 80,
                     size = 30,
                     price = 400,
                     img = " https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Poecilotheria_ornata_-_female_-_top_view.jpg/275px-Poecilotheria_ornata_-_female_-_top_view.jpg"
                },
                new brachypelma
                {
                     name = "poeciloteria miranda",
                     weight = 70,
                     size = 25,
                     price = 1000,
                     img = "https://www.spidersworld.eu/327/poecilotheria-miranda-25cm-bengal-ornamental.jpg"
                },
                new brachypelma
                {
                     name = "poeciloteria metallica",
                     color = "blue",
                     weight = 60,
                     size = 19,
                     price = 2500,
                     img = "https://pazitiff.info/uploads/posts/2015-09/1441394009_00fb7d5f3f0f7103a3cdffd2a8a0a14f.jpg"
                },
                new brachypelma
                {
                     name = "poeciloteria formosa",
                     weight = 70,
                     size = 22,
                     price = 900,
                     img = "https://ah.net.ua/wa-data/public/shop/products/83/46/4683/images/6205/6205.970.jpg"
                },
                new brachypelma
                {
                     name = "poeciloteria fasciata",
                     weight = 70,
                     size = 20,
                     price = 600,
                     img = "https://lh3.googleusercontent.com/proxy/yS_gphq-o6oW2Bv6uxCPygPjaGLdyYPMj7ePx3f_8Nn1KKmNxaZRss2w1lRQjZOHERLAZIzxelMY5n4W7LAUWNlyrAuvxTVKmK2Sx0yEp1OABOw"
                }
            };



            brachypelma albiceps = new brachypelma();
            brachypelma boehmei = new brachypelma();
            brachypelma smithi = new brachypelma();
            brachypelma klaasi = new brachypelma();
            brachypelma emilia = new brachypelma();
            brachypelma hamori = new brachypelma();

            poeciloteria fasciata = new poeciloteria();
            poeciloteria formosa = new poeciloteria();
            poeciloteria metallica = new poeciloteria();
            poeciloteria miranda = new poeciloteria();
            poeciloteria ornata = new poeciloteria();
            poeciloteria regalis = new poeciloteria();


            /////
            albiceps.name = "brachypelma albiceps";
            albiceps.weight = 50;
            albiceps.size = 15;
            albiceps.price = 400;
            albiceps.subColor = "brown";
            albiceps.hairPoison = 5;
            albiceps.img = "https://ah.net.ua/wa-data/public/shop/products/84/44/4484/images/5322/5322.650.jpg";

            boehmei.name = "brachypelma boehmei";
            boehmei.weight = 55;
            boehmei.size = 15;
            boehmei.price = 200;
            boehmei.subColor = "brown";
            boehmei.hairPoison = 3;
            boehmei.img = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Brachypelma_boehmei1.jpg/1200px-Brachypelma_boehmei1.jpg";

            smithi.name = "brachypelma smithi";
            smithi.weight = 60;
            smithi.size = 17;
            smithi.price = 500;
            smithi.subColor = "yellow";
            smithi.hairPoison = 2;
            smithi.img = "https://ireland.apollo.olxcdn.com/v1/files/5bgbgiji4n8s3-UA/image";

            klaasi.name = "brachypelma klaasi";
            klaasi.weight = 50;
            klaasi.size = 17;
            klaasi.price = 600;
            klaasi.subColor = "dark-brown";
            klaasi.hairPoison = 7;
            klaasi.img = "https://lh3.googleusercontent.com/proxy/oJL8R5BVwVvIxO5pQm3ndNghtQU5yIrByP2wksBybx_5Mu4F4kVnzEbjGrQnPPbnWGhpxMhUAD-8syCAmBRrBoix6ORtmk39YrD0hpaQ3Q";

            emilia.name = "brachypelma emilia";
            emilia.weight = 50;
            emilia.size = 15;
            emilia.price = 500;
            emilia.subColor = "dark-brown";
            emilia.hairPoison = 2;
            emilia.img = "https://lh3.googleusercontent.com/proxy/VnFoIj6YaPhnBAsv9vvJc_Rr07RwDVqfQAWrpIPWFldADjn3_BveN2QO3hHZsYUQNH4m5nImtVoDYiTKm7yz2FCcCuh6Jdb2YGz3qZ-a3-4";

            hamori.name = "brachypelma hamori";
            hamori.weight = 45;
            hamori.size = 13;
            hamori.price = 800;
            hamori.subColor = "brown";
            hamori.hairPoison = 5;
            hamori.img = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Brachypelma_smithi_2009_G09.jpg";
            //gulin

        }

        private void KindOfAnimalView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }
    }

}
