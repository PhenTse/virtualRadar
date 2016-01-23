﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InterfaceFactory;
using VirtualRadar.Interface;
using VirtualRadar.Interface.PortableBinding;
using VirtualRadar.Interface.Presenter;
using VirtualRadar.Interface.Settings;
using VirtualRadar.Interface.View;
using VirtualRadar.Interface.WebSite;
using VirtualRadar.Plugin.WebAdmin.View.Settings;

namespace VirtualRadar.Plugin.WebAdmin.View
{
    class SettingsView : ISettingsView
    {
        private ISettingsPresenter _Presenter;
        private ViewModel _ViewModel;

        private Configuration _Configuration;
        public Configuration Configuration
        {
            get { return _Configuration; }
            set {
                _Configuration = value;
                _ViewModel = new ViewModel(value);
            }
        }

        public NotifyList<IUser> Users { get; private set; }

        public string UserManager { get; set; }

        public string OpenOnPageTitle { get; set; }

        public object OpenOnRecord { get; set; }

        public event EventHandler SaveClicked;
        private void OnSaveClicked(EventArgs args)
        {
            EventHelper.Raise(SaveClicked, this, args);
        }

        public event EventHandler<EventArgs<Receiver>> TestConnectionClicked;

        public event EventHandler TestTextToSpeechSettingsClicked;

        public event EventHandler UpdateReceiverLocationsFromBaseStationDatabaseClicked;

        public event EventHandler UseIcaoRawDecodingSettingsClicked;

        public event EventHandler UseRecommendedRawDecodingSettingsClicked;

        public event EventHandler FlightSimulatorXOnlyClicked;

        public event EventHandler<EventArgs<string>> OpenUrlClicked;

        public DialogResult ShowView()
        {
            Users = new NotifyList<IUser>();

            _Presenter = Factory.Singleton.Resolve<ISettingsPresenter>();
            _Presenter.Initialise(this);

            return DialogResult.OK;
        }

        public void Dispose()
        {
            _Presenter.Dispose();
        }

        public void PopulateTextToSpeechVoices(IEnumerable<string> voiceNames)
        {
            ;
        }

        public void ShowTestConnectionResults(string message, string title)
        {
            ;
        }

        public void ShowAircraftDataLookupSettings(string dataSupplier, string supplierCredits, string supplierUrl)
        {
            ;
        }

        public object ShowBusy(bool isBusy, object previousState)
        {
            return null;
        }

        public void ShowValidationResults(ValidationResults results)
        {
            ;
        }

        [WebAdminMethod]
        public ViewModel GetState()
        {
            return _ViewModel;
        }

        [WebAdminMethod(DeferExecution=true)]
        public ViewModel RaiseSaveClicked(ConfigurationModel configurationModel)
        {
            _ViewModel.Configuration = configurationModel;
            _ViewModel.Configuration.CopyToConfiguration(Configuration);

            OnSaveClicked(EventArgs.Empty);

            return _ViewModel;
        }
    }
}
