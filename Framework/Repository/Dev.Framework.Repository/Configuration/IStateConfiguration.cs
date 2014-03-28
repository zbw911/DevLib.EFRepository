// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����IStateConfiguration.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

namespace Kt.Framework.Repository.Configuration
{
    /// <summary>
    /// Interface that can be implemented by classes that provide state configuration for Kt.Framework.Repository.
    /// </summary>
    public interface IStateConfiguration
    {
        /// <summary>
        /// Called by Kt.Framework.Repository <see cref="Configure"/> to configure state storage.
        /// </summary>
        /// <param name="containerAdapter">The <see cref="IContainerAdapter"/> instance that can be
        /// used to register state storage components.</param>
        void Configure(IContainerAdapter containerAdapter);
    }
}