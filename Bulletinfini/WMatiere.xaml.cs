﻿using MahApps.Metro.Controls;
using System.Collections.Generic;

namespace Bulletinfini
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WMatiere : MetroWindow
    {
            // InitializeComponent();

            public WMatiere()
            {
                InitializeComponent();
                List<Test> matiere = new List<Test>();
                matiere.Add(new Test(1, "Java", "Matière"));
                matiere.Add(new Test(2, "Anglais", "Matière"));
                matiere.Add(new Test(3, "Management", "Matière"));
                matiere.Add(new Test(4, "Réseaux", "Catégorie"));

                TableMatiere.ItemsSource = matiere;
            }
        }
        public class Test
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Type { get; set; }

            public Test(int id, string nom, string type)
            {
                Id = id;
                Nom = nom;
                Type = type;
            }


        }
    }
