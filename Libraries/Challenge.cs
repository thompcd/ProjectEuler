using System;
using System.Collections.Generic;

namespace Libraries
{
    public interface Challenge
    {
        void LoadParameters<T>(IEnumerable<T> input);

        void LoadParameters<T>(T input);

        string Solve();
    }

    public abstract class DailyProgrammerChallenge : Challenge
    {
        public virtual void LoadParameters<T>(IEnumerable<T> input)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadParameters<T>(T input)
        {
            throw new NotImplementedException();
        }

        public virtual string Solve()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class ProjectEulerChallenge : Challenge
    {
        public virtual void LoadParameters<T>(IEnumerable<T> input)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadParameters<T>(T input)
        {
            throw new NotImplementedException();
        }

        public virtual string Solve()
        {
            throw new NotImplementedException();
        }
    }
}