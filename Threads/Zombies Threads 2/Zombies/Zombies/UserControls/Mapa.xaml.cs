﻿using System;
using System.Collections.Generic;
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

namespace Zombies
{
    /// <summary>
    /// Lógica de interacción para Mapa.xaml
    /// </summary>
    public partial class Mapa : UserControl
    {
        public Mapa(int dimension)
        {
            InitializeComponent();

            for (int i = 0; i < dimension; i++)
            {
                Grilla.ColumnDefinitions.Add(new ColumnDefinition());
                Grilla.RowDefinitions.Add(new RowDefinition());
            }
        }
    }
}
