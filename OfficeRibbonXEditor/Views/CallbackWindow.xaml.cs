﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallbackWindow.xaml.cs" company="FA">
//   Fernando Andreu
// </copyright>
// <summary>
//   Simple viewer of the callbacks automatically generated
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OfficeRibbonXEditor.Views
{
    using System.Windows;

    using OfficeRibbonXEditor.Models;

    /// <summary>
    /// Interaction logic for CallbackWindow
    /// </summary>
    public partial class CallbackWindow : Window
    {
        private readonly VbaLexer lexer;

        public CallbackWindow(string code)
        {
            this.InitializeComponent();
            this.lexer = new VbaLexer { Editor = this.Editor };
            this.Editor.Text = code;
        }
    }
}
