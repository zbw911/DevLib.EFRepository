// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��21�� 16:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����EFConfiguration.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
using System;
using System.Data.Entity;
using Kt.Framework.Repository.Configuration;
 

namespace Kt.Framework.Repository.Data.EntityFramework5
{
    /// <summary>
    ///     Implementation of <see cref="IDataConfiguration" /> for Entity Framework.
    /// </summary>
    public class EFConfiguration : IDataConfiguration
    {
        private readonly EFUnitOfWorkFactory _factory = new EFUnitOfWorkFactory();

        /// <summary>
        ///     Called by Kt.Framework.Repository <see cref="Configure" /> to configure data providers.
        /// </summary>
        /// <param name="containerAdapter">
        ///     The <see cref="IContainerAdapter" /> instance that allows
        ///     registering components.
        /// </param>
        public void Configure(IContainerAdapter containerAdapter)
        {
            containerAdapter.RegisterInstance<IUnitOfWorkFactory>(_factory);
            containerAdapter.RegisterGeneric(typeof (IRepository<>), typeof (EFRepository<>));
        }

        /// <summary>
        ///     Configures unit of work instances to use the specified <see cref="DbContext" />.
        /// </summary>
        /// <param name="DbContextProvider">
        ///     A <see cref="Func{T}" /> of type <see cref="DbContext" />
        ///     that can be used to construct <see cref="DbContext" /> instances.
        /// </param>
        /// <returns>
        ///     <see cref="EFConfiguration" />
        /// </returns>
        public EFConfiguration WithObjectContext(Func<DbContext> objectContextProvider)
        {
            Guard.Against<ArgumentNullException>(objectContextProvider == null,
                                                 "Expected a non-null Func<ObjectContext> instance.");
            _factory.RegisterObjectContextProvider(objectContextProvider);
            return this;
        }
    }
}