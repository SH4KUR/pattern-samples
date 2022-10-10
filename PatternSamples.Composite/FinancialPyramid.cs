using System.Collections.Generic;
using System.Linq;

namespace PatternSamples.Composite
{
    public interface IFinancialPyramid
    {
        decimal CountMoney();
    }

    public class Person : IFinancialPyramid
    {
        private readonly decimal _money;

        public Person(decimal money)
        {
            _money = money;
        }

        public decimal CountMoney()
        {
            return _money;
        }
    }
    
    public class FinancialGroup : IFinancialPyramid
    {
        private readonly List<IFinancialPyramid> _members = new List<IFinancialPyramid>();

        public void Add(IFinancialPyramid financialMember)
        {
            _members.Add(financialMember);
        }
        
        public decimal CountMoney()
        {
            return _members.Sum(m => m.CountMoney());
        }
    }
}