using System;
using System.Collections.Generic;

namespace Libraries
{
    public abstract class Challenge
    {
        public virtual void LoadParameters<T>(IEnumerable<T> input){}
        public virtual void LoadParameters(string input) { }
        public virtual void LoadParameters(int input) { }
        public virtual void LoadParameters(double input) { }
        public virtual void LoadParameters(object input) { }

        public virtual string Solve(){throw new NotImplementedException();}
    }
}