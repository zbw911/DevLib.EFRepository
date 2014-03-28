// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����IDataConfiguration.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

namespace Kt.Framework.Repository.Configuration
{
    /// <summary>
    /// Base interface implemented by specific data configurators that configure Kt.Framework.Repository data providers.
    /// </summary>
    public interface IDataConfiguration
    {
        /// <summary>
        /// Called by Kt.Framework.Repository <see cref="Configure"/> to configure data providers.
        /// </summary>
        /// <param name="containerAdapter">The <see cref="IContainerAdapter"/> instance that allows
        /// registering components.</param>
        void Configure(IContainerAdapter containerAdapter);
    }
}