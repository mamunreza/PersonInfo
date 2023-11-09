import './App.css';
import PersonInformation from './components/PersonInformation';

function App() {
  return (
    <div className="main">
      <h2 className="main-header">Please enter your name and pick the Sectors you are currently involved in.</h2>
      <div>
        <PersonInformation />
      </div>
    </div>
  );
}

export default App;