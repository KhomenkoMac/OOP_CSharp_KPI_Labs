using System;

namespace Lab4_Part2.models
{
    #region Products
    public interface IColar
    {
        decimal Diameter { get; set; }
        decimal Price { get; set; }
        bool IsProvidedLighting { get; set; }
    }

    public class S_SizedColar : IColar
    {
        public decimal Diameter { get; set; } = 15.10M;
        public decimal Price { get; set; } = 122;
        public bool IsProvidedLighting { get; set; } = false;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Diameter)}: {Diameter}; {nameof(Price)} {Price}; {nameof(IsProvidedLighting)} {IsProvidedLighting}";
        }
    }

    public class M_SizedColar : IColar
    {
        public decimal Diameter { get; set; } = 19.10M;
        public decimal Price { get; set; } = 133;
        public bool IsProvidedLighting { get; set; } = false;

        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Diameter)}: {Diameter}; {nameof(Price)} {Price}; {nameof(IsProvidedLighting)} {IsProvidedLighting}";
        }
    }

    public class L_SizedColar : IColar
    {
        public decimal Diameter { get; set; } = 25.09M;
        public decimal Price { get; set; } = 500;
        public bool IsProvidedLighting { get; set; } = true;

        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Diameter)}: {Diameter}; {nameof(Price)} {Price}; {nameof(IsProvidedLighting)} {IsProvidedLighting}";
        }
    }


    public interface IMuzzle
    {
        decimal Length { get; set; }
    }

    public class S_SizedMuzzle : IMuzzle
    {
        public decimal Length { get; set; } = 10;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }

    public class M_SizedMuzzle : IMuzzle
    {
        public decimal Length { get; set; } = 15;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }

    public class L_SizedMuzzle : IMuzzle
    {
        public decimal Length { get; set; } = 20;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }


    public interface ILeash
    {
        decimal Length { get; set; }
        
    }

    public class S_SizedLeash : ILeash
    {
        public decimal Length { get; set; } = 58;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }

    public class M_SizedLeash : ILeash
    {
        public decimal Length { get; set; } = 88;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }

    public class L_SizedLeash : ILeash
    {
        public decimal Length { get; set; } = 68;
        public override string ToString()
        {
            return $"{this.GetType().Name} {nameof(Length)}: {Length};";
        }
    }
    #endregion

    #region Factories
    public class LFactory : IDogAccessoriesFactory
    {
        public IColar CreateColar()
        {
            return new L_SizedColar();
        }
        public IMuzzle CreateMuzzle()
        {
            return new L_SizedMuzzle();
        }
        public ILeash CreateLeash()
        {
            return new L_SizedLeash();
        }
    }

    public class MFactory : IDogAccessoriesFactory
    {
        public IColar CreateColar()
        {
            return new M_SizedColar();
        }
        public IMuzzle CreateMuzzle()
        {
            return new M_SizedMuzzle();
        }
        public ILeash CreateLeash()
        {
            return new M_SizedLeash();
        }
    }

    public class SFactory: IDogAccessoriesFactory
    {
        public IColar CreateColar()
        {
            return new S_SizedColar();
        }
        public ILeash CreateLeash()
        {
            return new S_SizedLeash();
        }
        public IMuzzle CreateMuzzle()
        {
            return new S_SizedMuzzle();
        }
    }
    #endregion

    #region The abstract factory
    public interface IDogAccessoriesFactory
    {
        public IMuzzle CreateMuzzle();
        public IColar CreateColar();
        public ILeash CreateLeash();
    }

    #endregion
}
