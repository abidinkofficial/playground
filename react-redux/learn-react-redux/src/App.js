import { connect } from 'react-redux';
import { INCREMENT, DECREMENT, RESET } from './actions';
import './App.css';

const mapStateToProps = (state) => {
  return {
    count: state.count
  }
}

const App = (props) => {

  const increment = () => {
    props.dispatch({ type: INCREMENT });
  }

  const decrement = () => {
    props.dispatch({ type: DECREMENT });
  }

  const reset = () => {
    props.dispatch({ type: RESET });
  }

  return (
    <div className="App">
      <h1>React Redux Playground</h1>
      <h2>Counter</h2>
      <div>
          <button onClick={decrement}>-</button>
          <span className='count-span'>{props.count}</span>
          <button onClick={increment}>+</button>
          <button onClick={reset} style={{display:'block'}}>Reset</button>
        </div>
    </div>
  );
}

export default connect(mapStateToProps)(App);
