namespace DesignPatterns.Behavioral_Patterns.Command
{
    public class CustomerServiceCommand : ICommand
    {
        private CustomerService _customerService;

        public CustomerServiceCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}