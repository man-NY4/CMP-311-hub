using System;

namespace RefactorEvent
{
    public interface ITotalFees // interface to print total fees for a tournament
    {
        double playerCost(string inp);
    }
}