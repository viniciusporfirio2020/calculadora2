﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        public static double valor01;
        public static double valor02;
        public static string op;
        public static double resultado;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "9";
        }

        private void ButtonSoma_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "+";
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "6";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "5";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "4";
        }

        private void ButtonMultiplicar_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += ;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "3";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "2";
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            entryValor.Text +=;
        }

        private void ButtonSubtrair_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "-";
        }

        private void Button0_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "-";
        }

        private void ButtonCE_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "";
        }

        private void ButtonResultado_Clicked(object sender, EventArgs e)
        {
            entryValor.Text = Convert.ToString(resultado);
        }

        private void ButtonDividir_Clicked(object sender, EventArgs e)
        {
            entryValor.Text += "/";
        }

        private void Button0_Clicked_1(object sender, EventArgs e)
        {
            entryValor.Text += "0";
        }
    }
