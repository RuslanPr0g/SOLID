namespace Open_Closed_Principle
{
    abstract class MealBase
    {
        public void Make()
        {
            Prepare();
            Cook();
            FinalSteps();
        }
        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
    }
}
