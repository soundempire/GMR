﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GMR.Models
{
    internal class TransactionViewModel : ICloneable
    {
        [Browsable(false)]
        public long ID { get; set; }

        [Browsable(false)]
        [Required]
        public long ContractorID { get; set; }

        [DisplayName("Дата")]
        [ReadOnly(true)]
        [Required]
        public DateTime Date { get; set; }

        [DisplayName("Транзакция")]
        public double? Value { get; set; } = null;

        [DisplayName("Платеж")]
        public double? Price { get; set; }

        [DisplayName("Курс")]
        [ReadOnly(true)]
        [Required]
        public double Currency { get; set; }

        object ICloneable.Clone() => MemberwiseClone();

        public override int GetHashCode() => (Date, Value, Price, Currency).GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is TransactionViewModel transactionModel)
            {
                if (ReferenceEquals(this, transactionModel))
                    return true;

                return Date == transactionModel.Date &&
                       Value == transactionModel.Value &&
                       Price == transactionModel.Price &&
                       Currency == transactionModel.Currency;
            }

            return false;
        }
    }
}
