// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����IState.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

namespace Kt.Framework.Repository.State
{
    /// <summary>
    /// Base IState interface.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Gets the application specific state.
        /// </summary>
        IApplicationState Application { get; }

        /// <summary>
        /// Gets the session specific state.
        /// </summary>
        ISessionState Session { get; }

        /// <summary>
        /// Gets the cache specific state.
        /// </summary>
        ICacheState Cache { get; }

        /// <summary>
        /// Gets the thread local / request local specific state.
        /// </summary>
        ILocalState Local { get; }
    }
}