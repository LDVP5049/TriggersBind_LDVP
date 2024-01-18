using System;
using System.Collections.Generic;
using System.Text;
using TriggersBind_LDVP.VistaModelo;
using TriggersBind_LDVP.Modelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace TriggersBind_LDVP.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;

        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value);}
        }
        #endregion
        #region PROCESOS
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        //Esto es lo que ocupo para darle funcion al boton
        public ICommand CalcularCommand => new Command(MostrarCategorias);
        #endregion
    }
}
