import { BowlersAndTeams } from '../types/BowlersAndTeams';
import { useEffect, useState } from 'react';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlersAndTeams[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5216/Bowler');
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr key={f.bowlerId}>
              <td>
                {f.bowlerFirstName} {f.bowlerMiddleInit} {f.bowlerLastName}
              </td>
              <td>{f.teamName}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
