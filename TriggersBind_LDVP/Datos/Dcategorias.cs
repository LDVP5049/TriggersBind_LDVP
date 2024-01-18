using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersBind_LDVP.Modelo;

namespace TriggersBind_LDVP.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>() {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/F3Z33w8/house-plants.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Hotel",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/F3Z33w8/house-plants.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/F3Z33w8/house-plants.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Flores",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/F3Z33w8/house-plants.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
            };
        }
    }
}
