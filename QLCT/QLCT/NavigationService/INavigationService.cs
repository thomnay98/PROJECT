using System;

namespace QLCT
{
    public interface INavigationService
    {
        void NavigateToPage(MasterPageItem item);

        void NavigateToPage(Type item, object parameter);

        void NavigatePopToRoot();
    }
}
