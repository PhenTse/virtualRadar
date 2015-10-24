﻿// Copyright © 2014 onwards, Andrew Whewell
// All rights reserved.
//
// Redistribution and use of this software in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//    * Neither the name of the author nor the names of the program's contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHORS OF THE SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceFactory;
using VirtualRadar.Interface;
using VirtualRadar.Interface.Presenter;
using VirtualRadar.Interface.View;

namespace VirtualRadar.Plugin.WebAdmin.View
{
    /// <summary>
    /// The class that carries the About view's data to the site.
    /// </summary>
    class AboutView : BaseView, IAboutView
    {
        IAboutPresenter _Presenter;

        public string Caption { get; set; }

        public string ProductName { get; set; }

        public string Version { get; set; }

        public DateTime BuildDate { get; set; }

        public string Copyright { get; set; }

        public string Description { get; set; }

        public string ConfigurationFolder
        {
            get { return ""; }
            set { ; }
        }

        public bool IsMono { get; set; }

        public event EventHandler OpenConfigurationFolderClicked;
        public void OnOpenConfigurationFolderClicked(EventArgs args)
        {
            EventHelper.Raise(OpenConfigurationFolderClicked, this, args);
        }

        public void ShowConfigurationFolderContents()
        {
            ;
        }

        public override System.Windows.Forms.DialogResult ShowView()
        {
            if(!IsRunning) {
                _Presenter = Factory.Singleton.Resolve<IAboutPresenter>();
                _Presenter.Initialise(this);
            }

            return base.ShowView();
        }
    }
}
