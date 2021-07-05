using PlannerMob.Entities.Mettings;
using PlannerMob.Refit.Interfaces;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlannerMob.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private ObservableCollection<Meeting> _selectedMeetings = new();

        private readonly IMeetingService _meetingService;

        private DateTime selectedStartDate;
        private DateTime selectedEndDate;

        private string _pickerTitle;
        private string _labelCaption;
        private bool _isBOthDatesEnabled;

        public ICommand ShowMeetings { get; set; }

        public ObservableCollection<Meeting> SelectedMeetings
        {
            get => _selectedMeetings;
            set => SetProperty(ref _selectedMeetings, value);
        }

        public HomePageViewModel()
        {
            _meetingService = App.GetService<IMeetingService>();
            ShowMeetings = new Command(() =>
            {
                if (!SelectedMeetings.Any())
                {
                    CrossToastPopUp.Current.ShowToastError("Nema učitanih sastanaka!");
                    return;
                }

                //SelectedMeetings.Clear();

                //(from meeting in SelectedMeetings
                // where meeting.Start >= SelectedStartDate && meeting.End <= SelectedEndDate
                // select meeting)?.ToList().ForEach(meeting => SelectedMeetings.Add(meeting));
            });
        }

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
                LoadAllMeetings();
                SelectedStartDate = DateTime.Now;
                SelectedEndDate = DateTime.Now;
            });
        }

        internal void Recalculate()
        {
            var timeSpan = SelectedEndDate.Subtract(SelectedStartDate) + (IsBothDatesEnabled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            if (timeSpan.Days <= 0)
                return;

            var text = timeSpan.Days > 1 ? "dana" : "dan";
            LabelCaptionText = $"{timeSpan.Days}" + " " + text;
        }

        private void LoadAllMeetings()
        {
            SelectedMeetings.Clear();
            SelectedMeetings.Add(new Meeting
            {
                AtendeeCount = 9,
                Start = DateTime.Parse("2020-09-24T11:59:01"),
                End = DateTime.Parse("2020-09-24T12:43:50"),
                Id = Guid.Parse("9150d8ec-3b8e-490d-543a-08d93b449d23"),
                Name = "meet",
                Organizer = "znedeljkovic.b518.17@one.pmf.uns.ac.rs"
            });
            //var meetings = _meetingService.GetMeetings();
            //if(meetings == null)
            //{
            //    CrossToastPopUp.Current.ShowToastError("Došlo je do greške prilikom učitavanja sastanka!");
            //    return;
            //}

            //meetings.ForEach(meetingDto =>
            //{
            //    var meeting = App.Mapper.Map<Meeting>(meetingDto);
            //    SelectedMeetings.Add(meeting);
            //});

            //await _meetingService.GetMeetings().ContinueWith(taskResult =>
            //{
            //    Device.InvokeOnMainThreadAsync(() =>
            //    {
            //        try
            //        {
            //            if (taskResult.IsFaulted)
            //            {
            //                CrossToastPopUp.Current.ShowToastError("Došlo je do greške prilikom učitavanja sastanka!");
            //                return;
            //            }

            //            if (taskResult.Result == null)
            //            {
            //                CrossToastPopUp.Current.ShowToastError("Došlo je do greške prilikom učitavanja sastanka!");
            //                return;
            //            }

            //            taskResult.Result.Meetings.ForEach(meetingDto =>
            //            {
            //                var meeting = App.Mapper.Map<Meeting>(meetingDto);
            //                _allMeetings.Add(meeting);
            //            });

            //        }
            //        catch (Exception e)
            //        {
            //            CrossToastPopUp.Current.ShowToastError(e.ToString());
            //            return;
            //        }
            //    });
            //});
        }
    }
}
