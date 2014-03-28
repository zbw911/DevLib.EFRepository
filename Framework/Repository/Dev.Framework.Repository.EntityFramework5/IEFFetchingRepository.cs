// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��21�� 16:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����IEFFetchingRepository.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
using System.Data.Entity;

namespace Kt.Framework.Repository.Data.EntityFramework5
{
    public interface IEFFetchingRepository<TEntity, TFetch> : IRepository<TEntity> where TEntity : DbSet
    {
        EFRepository<TEntity> RootRepository { get; }

        string FetchingPath { get; }
    }
}