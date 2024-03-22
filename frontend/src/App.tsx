import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerListComponent';

function App() {
  return (
    <div className="App">
      <Header title="Bowling League Database" />
      <BowlerList />
    </div>
  );
}

export default App;
