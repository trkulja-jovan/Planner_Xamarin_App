using PlannerMob.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PlannerMob.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        
        private DateTime selectedStartDate;
        private DateTime selectedEndDate;

        private string _pickerTitle;
        private string _labelCaption;
        private bool _isBOthDatesEnabled;

        public DateTime SelectedStartDate
        {
            get => selectedStartDate;
            set
            {
                SetProperty(ref selectedStartDate, value);
                Recalculate();
            }
        }
        public DateTime SelectedEndDate
        {
            get => selectedEndDate;
            set
            {
                SetProperty(ref selectedEndDate, value);
                Recalculate();
            }
        }
        public string PickerTitle
        {
            get => _pickerTitle;
            set => SetProperty(ref _pickerTitle, value);
        }
        public string LabelCaptionText
        {
            get => _labelCaption;
            set => SetProperty(ref _labelCaption, value);
        }
        public bool IsBothDatesEnabled
        {
            get => _isBOthDatesEnabled;
            set
            {
                SetProperty(ref _isBOthDatesEnabled, value);
                Recalculate();
            }
        }

  

        internal void InitializePage()
        {
            Device.InvokeOnMainThreadAsync(() =>
            {
            
                SelectedStartDate = DateTime.Now;
                SelectedEndDate = DateTime.Now;
          
            });
        }

        internal void Recalculate()
        {
            var timeSpan = SelectedEndDate.Subtract(SelectedStartDate) + (IsBothDatesEnabled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            LabelCaptionText = String.Format("{0} dan", timeSpan.Days, timeSpan.Days == 1 ? "" : "a");
        }

       
    }
}
