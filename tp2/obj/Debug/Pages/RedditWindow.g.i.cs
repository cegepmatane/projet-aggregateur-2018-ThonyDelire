﻿#pragma checksum "..\..\..\Pages\RedditWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EFC6DAE967CA16BC112D953BC2AF5440E28747B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using tp2;


namespace tp2 {
    
    
    /// <summary>
    /// RedditWindow
    /// </summary>
    public partial class RedditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Accueil;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Meteo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Rss;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button slack;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cryptomo;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pokemon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\RedditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas visuel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/tp2;component/pages/redditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RedditWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Accueil = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\RedditWindow.xaml"
            this.Accueil.Click += new System.Windows.RoutedEventHandler(this.Accueil_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Meteo = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\RedditWindow.xaml"
            this.Meteo.Click += new System.Windows.RoutedEventHandler(this.Meteo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Rss = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\RedditWindow.xaml"
            this.Rss.Click += new System.Windows.RoutedEventHandler(this.Rss_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.slack = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Pages\RedditWindow.xaml"
            this.slack.Click += new System.Windows.RoutedEventHandler(this.slack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cryptomo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\RedditWindow.xaml"
            this.cryptomo.Click += new System.Windows.RoutedEventHandler(this.cryptomo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pokemon = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\RedditWindow.xaml"
            this.pokemon.Click += new System.Windows.RoutedEventHandler(this.pokemon_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.visuel = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

