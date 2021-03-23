using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace PlannerMob.ViewModels
{
    public class CsvPageViewModel : BaseViewModel
    {
        public ICommand UploadCSVFileCommand { get; set; }

        public CsvPageViewModel()
        {
            UploadCSVFileCommand = new Command(() =>
            {

            });
        }

        //private async Task<FileResult> PickAndShow(PickOptions options)
        //{
        //    FilePicker.PickAsync(new PickOptions
        //    {
        //        FileTypes = FilePickerFileType.
        //    }); ;
        //}
    }
}
