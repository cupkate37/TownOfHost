using AmongUs.GameOptions;

using TownOfHost.Roles.Core;
using TownOfHost.Roles.Core.Interfaces;

namespace TownOfHost.Roles.Neutral;

public sealed class Opportunist : RoleBase, IAdditionalWinner
{
    public static readonly SimpleRoleInfo RoleInfo =
        new(
            typeof(Opportunist),
            player => new Opportunist(player),
            CustomRoles.Opportunist,
            () => RoleTypes.Crewmate,
            CustomRoleTypes.Neutral,
            50100,
            null,
            "op",
            "#00ff00"
        );
    public Opportunist(PlayerControl player)
    : base(
        RoleInfo,
        player
    )
    { }

    public bool CheckWin(out AdditionalWinners winnerType)
    {
        winnerType = AdditionalWinners.Opportunist;
        return Player.IsAlive();
    }
}
