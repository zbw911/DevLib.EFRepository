// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����IUnitOfWork.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

using System;

namespace Kt.Framework.Repository.Data
{
    /// <summary>
    /// A unit of work contract that that encapsulates the Unit of Work pattern.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Flushes the changes made in the unit of work to the data store.
        /// </summary>
        void Flush();
    }
}