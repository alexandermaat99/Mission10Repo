import logo from './logo.png';

function Header(props: any) {
  return (
    <>
      <header className="row navbar navbar-dark bg-dark">
        <div className="col-4">
          <img src={logo} className="logo" alt="logo" height={100} />
        </div>
        <div className="col subtitle">
          <h1 className="text-white">{props.title}</h1>
        </div>
      </header>
      <p>This site shows information of Bowlers from Marlins and Sharks</p>
    </>
  );
}

export default Header;
