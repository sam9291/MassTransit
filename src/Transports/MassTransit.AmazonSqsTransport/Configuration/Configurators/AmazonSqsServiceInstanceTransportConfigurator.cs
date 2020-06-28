namespace MassTransit.AmazonSqsTransport.Configurators
{
    using Conductor.Configurators;


    // ReSharper disable once UnusedType.Global
    public class AmazonSqsServiceInstanceTransportConfigurator :
        IServiceInstanceTransportConfigurator<IAmazonSqsReceiveEndpointConfigurator>
    {
        public void ConfigureServiceEndpoint(IAmazonSqsReceiveEndpointConfigurator configurator)
        {
        }

        public void ConfigureInstanceServiceEndpoint(IAmazonSqsReceiveEndpointConfigurator configurator)
        {
            configurator.ConfigureConsumeTopology = false;
        }

        public void ConfigureControlEndpoint(IAmazonSqsReceiveEndpointConfigurator configurator)
        {
            configurator.AutoDelete = true;
            configurator.Durable = false;
        }

        public void ConfigureInstanceEndpoint(IAmazonSqsReceiveEndpointConfigurator configurator)
        {
            configurator.AutoDelete = true;
            configurator.Durable = false;
        }
    }
}