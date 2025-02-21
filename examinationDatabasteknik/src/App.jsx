import { BrowserRouter, Route, Routes } from 'react-router-dom'
import './App.css'
import CreateProject from './pages/CreateProject'
import ListProject from './pages/ListProject'

function App() {

  return (
      <BrowserRouter>
        <Routes>
          <Route path='/projects/create' element={<CreateProject/>}/>
          <Route path='/projects' element={<ListProject/>}/>
          <Route path='/' element={<CreateProject/>}/>
        </Routes>
      </BrowserRouter>
  )
}

export default App
