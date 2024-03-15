import { useEffect, useState } from 'react';
import { Bowler } from './types/Bowler';
import { Team } from './types/Team';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);
  const [teamData, setTeamData] = useState<Team[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('https://localhost:7016/bowlingleague/bowlers');
      const b = await rsp.json();
      setBowlerData(b);
    };

    const fetchTeamData = async () => {
      const rsp = await fetch('https://localhost:7016/bowlingleague/teams');
      const t = await rsp.json();
      setTeamData(t);
    };

    fetchBowlerData();
    fetchTeamData();
  }, []);

  const getTeamName = (teamId: number): string => {
    const team = teamData.find((team) => team.teamId === teamId);
    return team ? team.teamName : '';
  };

  return (
    <div className="bowler-list">
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b: Bowler) => {
            if (b.teamId === 1 || b.teamId === 2) {
              return (
                <tr key={b.bowlerId}>
                  <td>
                    {b.bowlerFirstName}{' '}
                    {b.bowlerMiddleInit ? `${b.bowlerMiddleInit}.` : ''}{' '}
                    {b.bowlerLastName}
                  </td>
                  <td>{getTeamName(b.teamId)}</td>
                  <td>{b.bowlerAddress}</td>
                  <td>{b.bowlerCity}</td>
                  <td>{b.bowlerState}</td>
                  <td>{b.bowlerZip}</td>
                  <td>{b.bowlerPhoneNumber}</td>
                </tr>
              );
            }
            return null;
          })}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerList;
