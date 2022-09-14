using Fluxor;

namespace RoutingErrorsAndFluxor.Shared.Store;

public class SetAppError
{
    public class Action
    {
        public IEnumerable<string> ErrorMessages { get; private set; }

        public Action(string errorMessage)
            : this(new List<string>() { errorMessage })
        { }

        public Action(IEnumerable<string> errorMessages)
        {
            this.ErrorMessages = errorMessages;
        }
    }

    public class ActionReducer : Reducer<AppErrorState, Action>
    {
        public override AppErrorState Reduce(AppErrorState state, Action action) =>
            new AppErrorState(action.ErrorMessages);
    }
}
