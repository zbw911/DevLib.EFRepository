// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����UnitOfWorkSettings.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

using System.Transactions;

namespace Kt.Framework.Repository.Data.Impl
{
    ///<summary>
    /// Contains settings for Kt.Framework.Repository unit of work.
    ///</summary>
    public static class UnitOfWorkSettings
    {
        /// <summary>
        /// Gets the default <see cref="IsolationLevel"/>.
        /// </summary>
        public static IsolationLevel DefaultIsolation { get; set; }

        /// <summary>
        /// Gets a boolean value indicating weather to auto complete
        /// <see cref="UnitOfWorkScope"/> instances.
        /// </summary>
        public static bool AutoCompleteScope { get; set; }
    }
}