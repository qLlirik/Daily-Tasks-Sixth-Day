//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SixthDay.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rooms
    {
        public int ID { get; set; }
        public int NumberSign { get; set; }
        public byte BuildingID { get; set; }
        public string Prescribe { get; set; }
        public double SquareRoom { get; set; }
        public double HighRoom { get; set; }
        public int Storey { get; set; }
    
        public virtual Buildings Buildings { get; set; }
    }
}