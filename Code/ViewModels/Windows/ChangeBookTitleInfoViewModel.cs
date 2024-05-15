using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QLTV_Nhom13.ViewModels.Windows
{
    /*    https://stackoverflow.com/questions/10892233/add-delete-button-for-every-row-in-datagrid
     *    public class ChangeBookTitleInfoViewModel : INotifyPropertyChanged
        {
            private Result m_selectedResult;
            public Result SelectedResult
            {
                get { return m_selectedResult; }
                set
                {
                    m_selectedResult = value;
                    OnPropertyChanged("SelectedResult");
                }
            }

            private bool CanDelete
            {
                get { return SelectedResult != null; }
            }

            private ICommand m_deleteCommand;
            public ICommand DeleteCommand
            {
                get
                {
                    if (m_deleteCommand == null)
                    {
                        m_deleteCommand = new RelayCommand(param => Delete((Result)param), param => CanDelete);
                    }
                    return m_deleteCommand;
                }
            }

            private void Delete(Result result)
            {
                Results.Remove(result);
            }
        }*/
}
