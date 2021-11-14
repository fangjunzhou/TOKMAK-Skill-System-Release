﻿using System.Threading.Tasks;

namespace FinTOKMAK.SkillSystem
{
    public interface IRemoteSkillAgent
    {
        SkillManager skillManager
        {
            get;
            set;
        }
        
        /// <summary>
        /// Call a remote RPC of a certain skill.
        /// Should only call the rpc on the player who has authority.
        /// </summary>
        /// <param name="skill">The skill to call.</param>
        /// <param name="method">The method name.</param>
        /// <param name="methodParams">The method parameters.</param>
        /// <returns>The RPC return value.</returns>
        Task<object> RPCCall(Skill skill, string method, params object[] methodParams);
    }
}