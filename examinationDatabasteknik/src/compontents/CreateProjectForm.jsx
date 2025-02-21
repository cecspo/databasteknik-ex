import React from 'react'

const CreateProjectForm = () => {



  return (
    <section>
        <h1 className='header'></h1>
            <div className='container'>
                <form>
                    <div className='form-group'>
                    <label htmlFor='projectName'>Projektnamn</label>
                    <input type="text" id='projectName'/>
                </div>

                <div className='form-group'>
                    <label htmlFor='notes'>Noteringar</label>
                    <textarea name="notes" id='notes'></textarea>
                </div>

                <div className='form-group'>
                    <label htmlFor='customers'>Kunder</label>
                    <select name="customers" id='customers'></select>
                </div>

                <button type='submit'>Skapa</button>
                </form>
            </div>
    </section>
)
}

export default CreateProjectForm