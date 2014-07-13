﻿using System.Collections;
using Cardinal.IoC.Registration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Cardinal.IoC.Windsor
{
    public abstract class WindsorContainerAdapter : ContainerAdapter<IWindsorContainer>
    {
        protected WindsorContainerAdapter() : this(new WindsorContainer())
        {
            
        }

        protected WindsorContainerAdapter(IWindsorContainer container) : base(container)
        {
        }

        public override T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public override T Resolve<T>(string name)
        {
            return Container.Resolve<T>(name);
        }

        public override T Resolve<T>(IDictionary arguments)
        {
            return Container.Resolve<T>(arguments);
        }

        public override T Resolve<T>(string name, IDictionary arguments)
        {
            return Container.Resolve<T>(name, arguments);
        }

        public override void Register<TRegisteredAs, TResolvedTo>(IRegistrationDefinition<TRegisteredAs, TResolvedTo> registrationDefinition)
        {
            Container.Register(Component.For<TRegisteredAs>().ImplementedBy<TResolvedTo>());
        }
    }
}
