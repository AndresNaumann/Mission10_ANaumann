import logo from './naumannlanes.png';

function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo"></img>
      </div>
      <div className="col subtitle">
        <h1 style={{ color: 'white' }}>Naumann's Bowling League</h1>
      </div>
    </header>
  );
}

export default Header;
