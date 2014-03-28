// ***********************************************************************************
// Created by zbw911 
// �����ڣ�2012��12��18�� 13:28
// 
// �޸��ڣ�2013��02��18�� 18:24
// �ļ�����ISessionStateSelector.cs
// 
// ����и��õĽ����������ʼ���zbw911#gmail.com
// ***********************************************************************************
 

namespace Kt.Framework.Repository.State
{
    /// <summary>
    /// Interface that is implemented by a custom selector that creates instances of <see cref="ISessionState"/>.
    /// </summary>
    public interface ISessionStateSelector
    {
        /// <summary>
        /// Gets the implementation of <see cref="ISessionState"/> to use.
        /// </summary>
        /// <returns></returns>
        ISessionState Get();
    }
}