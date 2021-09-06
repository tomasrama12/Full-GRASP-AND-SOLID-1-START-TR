//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        //Costo insumos


        public double CostoInsumos
        {
            get
            {
                return CostoInsumos;
            }
            set
            {
                CostoInsumos = this.Input.UnitCost * this.Quantity;
            }
        } 

        public double CostoEquipamento
        {
            get
            {
                return CostoEquipamento;
            }
            set
            {
                CostoEquipamento = this.Equipment.HourlyCost * this.Time;
            }
        }

        

        

    }
}