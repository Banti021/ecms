import { ref, inject } from 'vue';

export function useReservations() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const reservations = ref([]);
    const reservation = ref(null);
    const error = ref(null);

    const fetchReservations = async () => {
        try {
            const response = await apiClient.get('/Reservation');
            reservations.value = response.data;
        } catch (err) {
            console.error('Error fetching reservations:', err);
            error.value = err;
        }
    };

    const fetchReservationById = async (id) => {
        try {
            const response = await apiClient.get(`/Reservation/${id}`);
            reservation.value = response.data;
        } catch (err) {
            console.error('Error fetching reservation by ID:', err);
            error.value = err;
        }
    };

    const addReservation = async (reservationData) => {
        try {
            console.log('Adding reservation:', reservationData);
            const response = await apiClient.post('/Reservation', reservationData);
            return response.data;
        } catch (err) {
            console.error('Failed to add reservation:', err);
            throw new Error('Failed to add reservation');
        }
    };

    const updateReservation = async (id, reservationDto) => {
        try {
            const response = await apiClient.put(`/Reservation/${id}`, reservationDto);
            return response.data;
        } catch (err) {
            console.error('Error updating reservation:', err);
            error.value = err;
            throw err;
        }
    };

    const deleteReservation = async (id) => {
        try {
            await apiClient.delete(`/Reservation/${id}`);
        } catch (err) {
            console.error('Error deleting reservation:', err);
            error.value = err;
            throw err;
        }
    };

    const getReservationsByStatus = async (status) => {
        try {
            const response = await apiClient.get(`/Reservation/status/${status}`);
            reservations.value = response.data;
        } catch (err) {
            console.error('Error getting reservations by status:', err);
            error.value = err;
            throw err;
        }
    };

    const confirmReservation = async (id) => {
        try {
            await apiClient.post(`/Reservation/confirm/${id}`);
        } catch (err) {
            console.error('Error confirming reservation:', err);
            error.value = err;
            throw err;
        }
    };

    const cancelReservation = async (id) => {
        try {
            await apiClient.post(`/Reservation/cancel/${id}`);
        } catch (err) {
            console.error('Error cancelling reservation:', err);
            error.value = err;
            throw err;
        }
    };

    const completeReservation = async (id) => {
        try {
            await apiClient.post(`/Reservation/complete/${id}`);
        } catch (err) {
            console.error('Error completing reservation:', err);
            error.value = err;
            throw err;
        }
    };

    const getReservationsByAreaAndDate = async (areaId, date) => {
        try {
            const response = await apiClient.get(`/Reservation/area/${areaId}/date/${date}`);
            return response.data;
        } catch (err) {
            console.error('Error getting reservations by area and date:', err);
            error.value = err;
            throw err;
        }
    };

    return {
        reservations,
        reservation,
        error,
        fetchReservations,
        fetchReservationById,
        addReservation,
        updateReservation,
        deleteReservation,
        getReservationsByStatus,
        confirmReservation,
        cancelReservation,
        completeReservation,
        getReservationsByAreaAndDate
    };
}
