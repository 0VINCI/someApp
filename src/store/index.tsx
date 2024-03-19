import { configureStore, combineReducers } from '@reduxjs/toolkit'
import { counselingCenterListSlice } from './../slice/councelingCenterSlice'

const store = configureStore({
    reducer: combineReducers({
        counselingCenterList: counselingCenterListSlice.reducer
    })
})

export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
export { store }