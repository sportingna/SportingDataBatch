using System;
using ProjectDataBatch.Controllers;
using ProjectDataBatch.Util;

namespace ProjectDataBatch
{
    class SportingAPIFactory
    {
        static public ISportingRequest GetRequest(string get)
        {
            ISportingRequest selector = null;
            switch (get)
            {
                case SportAPIUtil.Schedule:
                    selector = new Schedule();
                    break;
                case SportAPIUtil.LeagueHierarchy:
                    selector = new LeagueHierarchy();
                    break;
                case SportAPIUtil.TeamGameStatByDate:
                    selector = new TeamGameStatByDate();
                    break;
                case SportAPIUtil.Standings:
                    selector = new Standings();
                    break;
                case SportAPIUtil.PlayersByTeam:
                    selector = new PlayersByTeam();
                    break;
                case SportAPIUtil.CompetitionFixtures:
                    selector = new CompetitionFixtures();
                    break;
                case SportAPIUtil.PlayerGameStatsByDate:
                    selector = new PlayerGameStatsByDate();
                    break;
                case SportAPIUtil.PlayerSeasonStatsByTeam:
                    selector = new PlayerSeasonStatsByTeam();
                    break;
                case SportAPIUtil.GamesByDate:
                    selector = new GamesByDate();
                    break;
                case SportAPIUtil.BoxScore:
                    selector = new BoxScore();
                    break;
                case SportAPIUtil.CompetitionsByGameId:
                    selector = new CompetitionsByGameId();
                    break;
                case SportAPIUtil.BoxScoresByDateAndCompetition:
                    selector = new BoxScoresByDateAndCompetition();
                    break;
                case SportAPIUtil.Competitions:
                    selector = new Competitions();
                    break;
                default:
                    break;
            }
            return selector;
        }
    }

    class Competitions : SportingRequest
    {
        
    }

    class BoxScoresByDateAndCompetition : SportingRequest
    {
    }

    class CompetitionsByGameId : SportingRequest
    {
    }

    class BoxScore : SportingRequest
    {
    }

    class GamesByDate : SportingRequest
    {
    }

    class PlayerSeasonStatsByTeam : SportingRequest
    {
    }

    class PlayerGameStatsByDate : SportingRequest
    {
    }

    class CompetitionFixtures : SportingRequest
    {
    }

    class PlayersByTeam : SportingRequest
    {
    }

    class Standings : SportingRequest
    {
    }

    class TeamGameStatByDate : SportingRequest
    {
    }

    class LeagueHierarchy : SportingRequest
    {
    }

    class Schedule : SportingRequest
    {
    }
}

