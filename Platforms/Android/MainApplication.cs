using Android.App;
using Android.Runtime;
using MJSCJR_TacoslaEnredadaInterfaz.Models;

namespace MJSCJR_TacoslaEnredadaInterfaz
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
