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
            const response = await apiClient.get('/api/Reservation');
            reservations.value = response.data;
        } catch (err) {
            error.value = err;
        }
    };

    const fetchReservationById = async (id) => {
        try {
            const response = await apiClient.get(`/api/Reservation/${id}`);
            reservation.value = response.data;
        } catch (err) {
            error.value = err;
        }
    };

    const addReservation = async (reservationData) => {
        try {
            const response = await apiClient.post('/api/reservation', reservationData)
            return response.data
        } catch (error) {
            throw new Error('Failed to add reservation')
        }
    }

    const updateReservation = async (id, reservationDto) => {
        try {
            const response = await apiClient.put(`/api/Reservation/${id}`, reservationDto);
            return response.data;
        } catch (err) {
            error.value = err;
            throw err;
        }
    };

    const deleteReservation = async (id) => {
        try {
            await apiClient.delete(`/api/Reservation/${id}`);
        } catch (err) {
            error.value = err;
            throw err;
        }
    };

    const getReservationsByStatus = async (status) => {
        try {
            const response = await apiClient.get(`/api/Reservation/status/${status}`);
            reservations.value = response.data;
        } catch (err) {
            error.value = err;
            throw err;
        }
    };

    const confirmReservation = async (id) => {
        try {
            await apiClient.post(`/api/Reservation/confirm/${id}`);
        } catch (err) {
            error.value = err;
            throw err;
        }
    };

    const cancelReservation = async (id) => {
        try {
            await apiClient.post(`/api/Reservation/cancel/${id}`);
        } catch (err) {
            error.value = err;
            throw err;
        }
    };

    const completeReservation = async (id) => {
        try {
            await apiClient.post(`/api/Reservation/complete/${id}`);
        } catch (err) {
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
    };
}
